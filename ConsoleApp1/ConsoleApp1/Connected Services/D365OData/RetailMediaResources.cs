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
    /// There are no comments for RetailMediaResourcesSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailMediaResourcesSingle")]
    public partial class RetailMediaResourcesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailMediaResources>
    {
        /// <summary>
        /// Initialize a new RetailMediaResourcesSingle object.
        /// </summary>
        public RetailMediaResourcesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailMediaResourcesSingle object.
        /// </summary>
        public RetailMediaResourcesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailMediaResourcesSingle object.
        /// </summary>
        public RetailMediaResourcesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailMediaResources> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailMediaResources in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ResourceId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ResourceId")]
    [global::Microsoft.OData.Client.EntitySet("RetailMediaResources")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailMediaResources")]
    public partial class RetailMediaResources : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailMediaResources object.
        /// </summary>
        /// <param name="resourceId">Initial value of ResourceId.</param>
        /// <param name="smallImageSharedStorageId">Initial value of SmallImageSharedStorageId.</param>
        /// <param name="sizeInKilobytes">Initial value of SizeInKilobytes.</param>
        /// <param name="height">Initial value of Height.</param>
        /// <param name="sharedStorageId">Initial value of SharedStorageId.</param>
        /// <param name="instanceRelationType">Initial value of InstanceRelationType.</param>
        /// <param name="width">Initial value of Width.</param>
        /// <param name="thumbnailSharedStorageId">Initial value of ThumbnailSharedStorageId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailMediaResources CreateRetailMediaResources(int resourceId, 
                    global::System.Guid smallImageSharedStorageId, 
                    int sizeInKilobytes, 
                    int height, 
                    global::System.Guid sharedStorageId, 
                    long instanceRelationType, 
                    int width, 
                    global::System.Guid thumbnailSharedStorageId)
        {
            RetailMediaResources retailMediaResources = new RetailMediaResources();
            retailMediaResources.ResourceId = resourceId;
            retailMediaResources.SmallImageSharedStorageId = smallImageSharedStorageId;
            retailMediaResources.SizeInKilobytes = sizeInKilobytes;
            retailMediaResources.Height = height;
            retailMediaResources.SharedStorageId = sharedStorageId;
            retailMediaResources.InstanceRelationType = instanceRelationType;
            retailMediaResources.Width = width;
            retailMediaResources.ThumbnailSharedStorageId = thumbnailSharedStorageId;
            return retailMediaResources;
        }
        /// <summary>
        /// There are no comments for Property ResourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ResourceId is required.")]
        public virtual int ResourceId
        {
            get
            {
                return this._ResourceId;
            }
            set
            {
                this.OnResourceIdChanging(value);
                this._ResourceId = value;
                this.OnResourceIdChanged();
                this.OnPropertyChanged("ResourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ResourceId;
        partial void OnResourceIdChanging(int value);
        partial void OnResourceIdChanged();
        /// <summary>
        /// There are no comments for Property SmallImageSharedStorageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SmallImageSharedStorageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SmallImageSharedStorageId is required.")]
        public virtual global::System.Guid SmallImageSharedStorageId
        {
            get
            {
                return this._SmallImageSharedStorageId;
            }
            set
            {
                this.OnSmallImageSharedStorageIdChanging(value);
                this._SmallImageSharedStorageId = value;
                this.OnSmallImageSharedStorageIdChanged();
                this.OnPropertyChanged("SmallImageSharedStorageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _SmallImageSharedStorageId;
        partial void OnSmallImageSharedStorageIdChanging(global::System.Guid value);
        partial void OnSmallImageSharedStorageIdChanged();
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
        /// There are no comments for Property IsCustomer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCustomer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCustomer
        {
            get
            {
                return this._IsCustomer;
            }
            set
            {
                this.OnIsCustomerChanging(value);
                this._IsCustomer = value;
                this.OnIsCustomerChanged();
                this.OnPropertyChanged("IsCustomer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCustomer;
        partial void OnIsCustomerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCustomerChanged();
        /// <summary>
        /// There are no comments for Property FileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileName")]
        public virtual string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this.OnFileNameChanging(value);
                this._FileName = value;
                this.OnFileNameChanged();
                this.OnPropertyChanged("FileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileName;
        partial void OnFileNameChanging(string value);
        partial void OnFileNameChanged();
        /// <summary>
        /// There are no comments for Property IsPos in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPos")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPos
        {
            get
            {
                return this._IsPos;
            }
            set
            {
                this.OnIsPosChanging(value);
                this._IsPos = value;
                this.OnIsPosChanged();
                this.OnPropertyChanged("IsPos");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPos;
        partial void OnIsPosChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPosChanged();
        /// <summary>
        /// There are no comments for Property IsSecuredResource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsSecuredResource")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSecuredResource
        {
            get
            {
                return this._IsSecuredResource;
            }
            set
            {
                this.OnIsSecuredResourceChanging(value);
                this._IsSecuredResource = value;
                this.OnIsSecuredResourceChanged();
                this.OnPropertyChanged("IsSecuredResource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSecuredResource;
        partial void OnIsSecuredResourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSecuredResourceChanged();
        /// <summary>
        /// There are no comments for Property SizeInKilobytes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SizeInKilobytes")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SizeInKilobytes is required.")]
        public virtual int SizeInKilobytes
        {
            get
            {
                return this._SizeInKilobytes;
            }
            set
            {
                this.OnSizeInKilobytesChanging(value);
                this._SizeInKilobytes = value;
                this.OnSizeInKilobytesChanged();
                this.OnPropertyChanged("SizeInKilobytes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SizeInKilobytes;
        partial void OnSizeInKilobytesChanging(int value);
        partial void OnSizeInKilobytesChanged();
        /// <summary>
        /// There are no comments for Property Height in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Height")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Height is required.")]
        public virtual int Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this.OnHeightChanging(value);
                this._Height = value;
                this.OnHeightChanged();
                this.OnPropertyChanged("Height");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Height;
        partial void OnHeightChanging(int value);
        partial void OnHeightChanged();
        /// <summary>
        /// There are no comments for Property SharedStorageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SharedStorageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SharedStorageId is required.")]
        public virtual global::System.Guid SharedStorageId
        {
            get
            {
                return this._SharedStorageId;
            }
            set
            {
                this.OnSharedStorageIdChanging(value);
                this._SharedStorageId = value;
                this.OnSharedStorageIdChanged();
                this.OnPropertyChanged("SharedStorageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _SharedStorageId;
        partial void OnSharedStorageIdChanging(global::System.Guid value);
        partial void OnSharedStorageIdChanged();
        /// <summary>
        /// There are no comments for Property IsWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsWorker")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsWorker
        {
            get
            {
                return this._IsWorker;
            }
            set
            {
                this.OnIsWorkerChanging(value);
                this._IsWorker = value;
                this.OnIsWorkerChanged();
                this.OnPropertyChanged("IsWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsWorker;
        partial void OnIsWorkerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsWorkerChanged();
        /// <summary>
        /// There are no comments for Property IsExternallyHosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsExternallyHosted")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsExternallyHosted
        {
            get
            {
                return this._IsExternallyHosted;
            }
            set
            {
                this.OnIsExternallyHostedChanging(value);
                this._IsExternallyHosted = value;
                this.OnIsExternallyHostedChanged();
                this.OnPropertyChanged("IsExternallyHosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsExternallyHosted;
        partial void OnIsExternallyHostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsExternallyHostedChanged();
        /// <summary>
        /// There are no comments for Property IsPartialUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isPartialUrl")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPartialUrl
        {
            get
            {
                return this._IsPartialUrl;
            }
            set
            {
                this.OnIsPartialUrlChanging(value);
                this._IsPartialUrl = value;
                this.OnIsPartialUrlChanged();
                this.OnPropertyChanged("isPartialUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPartialUrl;
        partial void OnIsPartialUrlChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPartialUrlChanged();
        /// <summary>
        /// There are no comments for Property InstanceRelationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InstanceRelationType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InstanceRelationType is required.")]
        public virtual long InstanceRelationType
        {
            get
            {
                return this._InstanceRelationType;
            }
            set
            {
                this.OnInstanceRelationTypeChanging(value);
                this._InstanceRelationType = value;
                this.OnInstanceRelationTypeChanged();
                this.OnPropertyChanged("InstanceRelationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _InstanceRelationType;
        partial void OnInstanceRelationTypeChanging(long value);
        partial void OnInstanceRelationTypeChanged();
        /// <summary>
        /// There are no comments for Property Width in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Width")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Width is required.")]
        public virtual int Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this.OnWidthChanging(value);
                this._Width = value;
                this.OnWidthChanged();
                this.OnPropertyChanged("Width");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Width;
        partial void OnWidthChanging(int value);
        partial void OnWidthChanged();
        /// <summary>
        /// There are no comments for Property IsCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCategory
        {
            get
            {
                return this._IsCategory;
            }
            set
            {
                this.OnIsCategoryChanging(value);
                this._IsCategory = value;
                this.OnIsCategoryChanged();
                this.OnPropertyChanged("IsCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCategory;
        partial void OnIsCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCategoryChanged();
        /// <summary>
        /// There are no comments for Property IsCatalog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCatalog")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCatalog
        {
            get
            {
                return this._IsCatalog;
            }
            set
            {
                this.OnIsCatalogChanging(value);
                this._IsCatalog = value;
                this.OnIsCatalogChanged();
                this.OnPropertyChanged("IsCatalog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCatalog;
        partial void OnIsCatalogChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCatalogChanged();
        /// <summary>
        /// There are no comments for Property ThumbnailSharedStorageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ThumbnailSharedStorageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ThumbnailSharedStorageId is required.")]
        public virtual global::System.Guid ThumbnailSharedStorageId
        {
            get
            {
                return this._ThumbnailSharedStorageId;
            }
            set
            {
                this.OnThumbnailSharedStorageIdChanging(value);
                this._ThumbnailSharedStorageId = value;
                this.OnThumbnailSharedStorageIdChanged();
                this.OnPropertyChanged("ThumbnailSharedStorageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ThumbnailSharedStorageId;
        partial void OnThumbnailSharedStorageIdChanging(global::System.Guid value);
        partial void OnThumbnailSharedStorageIdChanged();
        /// <summary>
        /// There are no comments for Property InUse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InUse")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InUse
        {
            get
            {
                return this._InUse;
            }
            set
            {
                this.OnInUseChanging(value);
                this._InUse = value;
                this.OnInUseChanged();
                this.OnPropertyChanged("InUse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InUse;
        partial void OnInUseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInUseChanged();
        /// <summary>
        /// There are no comments for Property SmallImageUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SmallImageUrl")]
        public virtual string SmallImageUrl
        {
            get
            {
                return this._SmallImageUrl;
            }
            set
            {
                this.OnSmallImageUrlChanging(value);
                this._SmallImageUrl = value;
                this.OnSmallImageUrlChanged();
                this.OnPropertyChanged("SmallImageUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SmallImageUrl;
        partial void OnSmallImageUrlChanging(string value);
        partial void OnSmallImageUrlChanged();
        /// <summary>
        /// There are no comments for Property ResourceUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceUrl")]
        public virtual string ResourceUrl
        {
            get
            {
                return this._ResourceUrl;
            }
            set
            {
                this.OnResourceUrlChanging(value);
                this._ResourceUrl = value;
                this.OnResourceUrlChanged();
                this.OnPropertyChanged("ResourceUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceUrl;
        partial void OnResourceUrlChanging(string value);
        partial void OnResourceUrlChanged();
        /// <summary>
        /// There are no comments for Property ThumbnailUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ThumbnailUrl")]
        public virtual string ThumbnailUrl
        {
            get
            {
                return this._ThumbnailUrl;
            }
            set
            {
                this.OnThumbnailUrlChanging(value);
                this._ThumbnailUrl = value;
                this.OnThumbnailUrlChanged();
                this.OnPropertyChanged("ThumbnailUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ThumbnailUrl;
        partial void OnThumbnailUrlChanging(string value);
        partial void OnThumbnailUrlChanged();
        /// <summary>
        /// There are no comments for Property IsProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsProduct")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProduct
        {
            get
            {
                return this._IsProduct;
            }
            set
            {
                this.OnIsProductChanging(value);
                this._IsProduct = value;
                this.OnIsProductChanged();
                this.OnPropertyChanged("IsProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProduct;
        partial void OnIsProductChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProductChanged();
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
