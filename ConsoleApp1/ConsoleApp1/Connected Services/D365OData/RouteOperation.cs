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
    /// There are no comments for RouteOperationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RouteOperationSingle")]
    public partial class RouteOperationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RouteOperation>
    {
        /// <summary>
        /// Initialize a new RouteOperationSingle object.
        /// </summary>
        public RouteOperationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RouteOperationSingle object.
        /// </summary>
        public RouteOperationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RouteOperationSingle object.
        /// </summary>
        public RouteOperationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RouteOperation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Operation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Operation")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationSingle Operation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Operation == null))
                {
                    this._Operation = new global::Microsoft.Dynamics.DataEntities.OperationSingle(this.Context, GetPath("Operation"));
                }
                return this._Operation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationSingle _Operation;
        /// <summary>
        /// There are no comments for RouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RouteHeader")]
        public virtual global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle RouteHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RouteHeader == null))
                {
                    this._RouteHeader = new global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle(this.Context, GetPath("RouteHeader"));
                }
                return this._RouteHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RouteHeaderSingle _RouteHeader;
    }
    /// <summary>
    /// There are no comments for RouteOperation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RouteId
    /// OperationNumber
    /// OperationPriority
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RouteId", "OperationNumber", "OperationPriority")]
    [global::Microsoft.OData.Client.EntitySet("RouteOperations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RouteOperation")]
    public partial class RouteOperation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RouteOperation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="routeId">Initial value of RouteId.</param>
        /// <param name="operationNumber">Initial value of OperationNumber.</param>
        /// <param name="operationPriority">Initial value of OperationPriority.</param>
        /// <param name="accumulatedScrapPercentage">Initial value of AccumulatedScrapPercentage.</param>
        /// <param name="nextRouteOperationNumber">Initial value of NextRouteOperationNumber.</param>
        /// <param name="scrapPercentage">Initial value of ScrapPercentage.</param>
        /// <param name="operation">Initial value of Operation.</param>
        /// <param name="routeHeader">Initial value of RouteHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RouteOperation CreateRouteOperation(string dataAreaId, 
                    string routeId, 
                    int operationNumber, 
                    int operationPriority, 
                    decimal accumulatedScrapPercentage, 
                    int nextRouteOperationNumber, 
                    decimal scrapPercentage, 
                    global::Microsoft.Dynamics.DataEntities.Operation operation, 
                    global::Microsoft.Dynamics.DataEntities.RouteHeader routeHeader)
        {
            RouteOperation routeOperation = new RouteOperation();
            routeOperation.DataAreaId = dataAreaId;
            routeOperation.RouteId = routeId;
            routeOperation.OperationNumber = operationNumber;
            routeOperation.OperationPriority = operationPriority;
            routeOperation.AccumulatedScrapPercentage = accumulatedScrapPercentage;
            routeOperation.NextRouteOperationNumber = nextRouteOperationNumber;
            routeOperation.ScrapPercentage = scrapPercentage;
            if ((operation == null))
            {
                throw new global::System.ArgumentNullException("operation");
            }
            routeOperation.Operation = operation;
            if ((routeHeader == null))
            {
                throw new global::System.ArgumentNullException("routeHeader");
            }
            routeOperation.RouteHeader = routeHeader;
            return routeOperation;
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
        /// There are no comments for Property RouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RouteId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RouteId is required.")]
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
        /// There are no comments for Property OperationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperationNumber is required.")]
        public virtual int OperationNumber
        {
            get
            {
                return this._OperationNumber;
            }
            set
            {
                this.OnOperationNumberChanging(value);
                this._OperationNumber = value;
                this.OnOperationNumberChanged();
                this.OnPropertyChanged("OperationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OperationNumber;
        partial void OnOperationNumberChanging(int value);
        partial void OnOperationNumberChanged();
        /// <summary>
        /// There are no comments for Property OperationPriority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationPriority")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OperationPriority is required.")]
        public virtual int OperationPriority
        {
            get
            {
                return this._OperationPriority;
            }
            set
            {
                this.OnOperationPriorityChanging(value);
                this._OperationPriority = value;
                this.OnOperationPriorityChanged();
                this.OnPropertyChanged("OperationPriority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OperationPriority;
        partial void OnOperationPriorityChanging(int value);
        partial void OnOperationPriorityChanged();
        /// <summary>
        /// There are no comments for Property AccumulatedScrapPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccumulatedScrapPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccumulatedScrapPercentage is required.")]
        public virtual decimal AccumulatedScrapPercentage
        {
            get
            {
                return this._AccumulatedScrapPercentage;
            }
            set
            {
                this.OnAccumulatedScrapPercentageChanging(value);
                this._AccumulatedScrapPercentage = value;
                this.OnAccumulatedScrapPercentageChanged();
                this.OnPropertyChanged("AccumulatedScrapPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccumulatedScrapPercentage;
        partial void OnAccumulatedScrapPercentageChanging(decimal value);
        partial void OnAccumulatedScrapPercentageChanged();
        /// <summary>
        /// There are no comments for Property NextRouteOperationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NextRouteOperationNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NextRouteOperationNumber is required.")]
        public virtual int NextRouteOperationNumber
        {
            get
            {
                return this._NextRouteOperationNumber;
            }
            set
            {
                this.OnNextRouteOperationNumberChanging(value);
                this._NextRouteOperationNumber = value;
                this.OnNextRouteOperationNumberChanged();
                this.OnPropertyChanged("NextRouteOperationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NextRouteOperationNumber;
        partial void OnNextRouteOperationNumberChanging(int value);
        partial void OnNextRouteOperationNumberChanged();
        /// <summary>
        /// There are no comments for Property ScrapPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScrapPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScrapPercentage is required.")]
        public virtual decimal ScrapPercentage
        {
            get
            {
                return this._ScrapPercentage;
            }
            set
            {
                this.OnScrapPercentageChanging(value);
                this._ScrapPercentage = value;
                this.OnScrapPercentageChanged();
                this.OnPropertyChanged("ScrapPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ScrapPercentage;
        partial void OnScrapPercentageChanging(decimal value);
        partial void OnScrapPercentageChanged();
        /// <summary>
        /// There are no comments for Property NextOperationAttachmentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NextOperationAttachmentType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SchedJobLinkType> NextOperationAttachmentType
        {
            get
            {
                return this._NextOperationAttachmentType;
            }
            set
            {
                this.OnNextOperationAttachmentTypeChanging(value);
                this._NextOperationAttachmentType = value;
                this.OnNextOperationAttachmentTypeChanged();
                this.OnPropertyChanged("NextOperationAttachmentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SchedJobLinkType> _NextOperationAttachmentType;
        partial void OnNextOperationAttachmentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SchedJobLinkType> value);
        partial void OnNextOperationAttachmentTypeChanged();
        /// <summary>
        /// There are no comments for Property OperationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationId")]
        public virtual string OperationId
        {
            get
            {
                return this._OperationId;
            }
            set
            {
                this.OnOperationIdChanging(value);
                this._OperationId = value;
                this.OnOperationIdChanged();
                this.OnPropertyChanged("OperationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperationId;
        partial void OnOperationIdChanging(string value);
        partial void OnOperationIdChanged();
        /// <summary>
        /// There are no comments for Property Operation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Operation")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Operation is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Operation Operation
        {
            get
            {
                return this._Operation;
            }
            set
            {
                this.OnOperationChanging(value);
                this._Operation = value;
                this.OnOperationChanged();
                this.OnPropertyChanged("Operation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Operation _Operation;
        partial void OnOperationChanging(global::Microsoft.Dynamics.DataEntities.Operation value);
        partial void OnOperationChanged();
        /// <summary>
        /// There are no comments for Property RouteHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RouteHeader")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RouteHeader is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RouteHeader RouteHeader
        {
            get
            {
                return this._RouteHeader;
            }
            set
            {
                this.OnRouteHeaderChanging(value);
                this._RouteHeader = value;
                this.OnRouteHeaderChanged();
                this.OnPropertyChanged("RouteHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RouteHeader _RouteHeader;
        partial void OnRouteHeaderChanging(global::Microsoft.Dynamics.DataEntities.RouteHeader value);
        partial void OnRouteHeaderChanged();
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
