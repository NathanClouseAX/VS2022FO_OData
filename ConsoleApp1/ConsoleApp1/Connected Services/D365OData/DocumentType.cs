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
    /// There are no comments for DocumentTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTypeSingle")]
    public partial class DocumentTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DocumentType>
    {
        /// <summary>
        /// Initialize a new DocumentTypeSingle object.
        /// </summary>
        public DocumentTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DocumentTypeSingle object.
        /// </summary>
        public DocumentTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DocumentTypeSingle object.
        /// </summary>
        public DocumentTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DocumentType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductDocumentAttachments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductDocumentAttachments")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment> ProductDocumentAttachments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductDocumentAttachments == null))
                {
                    this._ProductDocumentAttachments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment>(GetPath("ProductDocumentAttachments"));
                }
                return this._ProductDocumentAttachments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment> _ProductDocumentAttachments;
    }
    /// <summary>
    /// There are no comments for DocumentType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ID")]
    [global::Microsoft.OData.Client.EntitySet("DocumentTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentType")]
    public partial class DocumentType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DocumentType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="ID">Initial value of ID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DocumentType CreateDocumentType(string dataAreaId, string ID)
        {
            DocumentType documentType = new DocumentType();
            documentType.DataAreaId = dataAreaId;
            documentType.ID = ID;
            return documentType;
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
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ID is required.")]
        public virtual string ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ID;
        partial void OnIDChanging(string value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property FileRemovalConfirmation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileRemovalConfirmation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> FileRemovalConfirmation
        {
            get
            {
                return this._FileRemovalConfirmation;
            }
            set
            {
                this.OnFileRemovalConfirmationChanging(value);
                this._FileRemovalConfirmation = value;
                this.OnFileRemovalConfirmationChanged();
                this.OnPropertyChanged("FileRemovalConfirmation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _FileRemovalConfirmation;
        partial void OnFileRemovalConfirmationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnFileRemovalConfirmationChanged();
        /// <summary>
        /// There are no comments for Property DocuStructureType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocuStructureType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuStructureType> DocuStructureType
        {
            get
            {
                return this._DocuStructureType;
            }
            set
            {
                this.OnDocuStructureTypeChanging(value);
                this._DocuStructureType = value;
                this.OnDocuStructureTypeChanged();
                this.OnPropertyChanged("DocuStructureType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuStructureType> _DocuStructureType;
        partial void OnDocuStructureTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuStructureType> value);
        partial void OnDocuStructureTypeChanged();
        /// <summary>
        /// There are no comments for Property FilePlace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FilePlace")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuFilePlace> FilePlace
        {
            get
            {
                return this._FilePlace;
            }
            set
            {
                this.OnFilePlaceChanging(value);
                this._FilePlace = value;
                this.OnFilePlaceChanged();
                this.OnPropertyChanged("FilePlace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuFilePlace> _FilePlace;
        partial void OnFilePlaceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuFilePlace> value);
        partial void OnFilePlaceChanged();
        /// <summary>
        /// There are no comments for Property TypeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeGroup")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuTypeGroup> TypeGroup
        {
            get
            {
                return this._TypeGroup;
            }
            set
            {
                this.OnTypeGroupChanging(value);
                this._TypeGroup = value;
                this.OnTypeGroupChanged();
                this.OnPropertyChanged("TypeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuTypeGroup> _TypeGroup;
        partial void OnTypeGroupChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuTypeGroup> value);
        partial void OnTypeGroupChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ActionClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActionClassName")]
        public virtual string ActionClassName
        {
            get
            {
                return this._ActionClassName;
            }
            set
            {
                this.OnActionClassNameChanging(value);
                this._ActionClassName = value;
                this.OnActionClassNameChanged();
                this.OnPropertyChanged("ActionClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActionClassName;
        partial void OnActionClassNameChanging(string value);
        partial void OnActionClassNameChanged();
        /// <summary>
        /// There are no comments for Property Site in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Site")]
        public virtual string Site
        {
            get
            {
                return this._Site;
            }
            set
            {
                this.OnSiteChanging(value);
                this._Site = value;
                this.OnSiteChanged();
                this.OnPropertyChanged("Site");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Site;
        partial void OnSiteChanging(string value);
        partial void OnSiteChanged();
        /// <summary>
        /// There are no comments for Property Host in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Host")]
        public virtual string Host
        {
            get
            {
                return this._Host;
            }
            set
            {
                this.OnHostChanging(value);
                this._Host = value;
                this.OnHostChanged();
                this.OnPropertyChanged("Host");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Host;
        partial void OnHostChanging(string value);
        partial void OnHostChanged();
        /// <summary>
        /// There are no comments for Property RemoveOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RemoveOption")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRemoveOption> RemoveOption
        {
            get
            {
                return this._RemoveOption;
            }
            set
            {
                this.OnRemoveOptionChanging(value);
                this._RemoveOption = value;
                this.OnRemoveOptionChanged();
                this.OnPropertyChanged("RemoveOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRemoveOption> _RemoveOption;
        partial void OnRemoveOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRemoveOption> value);
        partial void OnRemoveOptionChanged();
        /// <summary>
        /// There are no comments for Property Parameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Parameters")]
        public virtual byte[] Parameters
        {
            get
            {
                return this._Parameters;
            }
            set
            {
                this.OnParametersChanging(value);
                this._Parameters = value;
                this.OnParametersChanged();
                this.OnPropertyChanged("Parameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Parameters;
        partial void OnParametersChanging(byte[] value);
        partial void OnParametersChanged();
        /// <summary>
        /// There are no comments for Property FolderPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FolderPath")]
        public virtual string FolderPath
        {
            get
            {
                return this._FolderPath;
            }
            set
            {
                this.OnFolderPathChanging(value);
                this._FolderPath = value;
                this.OnFolderPathChanged();
                this.OnPropertyChanged("FolderPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FolderPath;
        partial void OnFolderPathChanging(string value);
        partial void OnFolderPathChanged();
        /// <summary>
        /// There are no comments for Property ProductDocumentAttachments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProductDocumentAttachments")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment> ProductDocumentAttachments
        {
            get
            {
                return this._ProductDocumentAttachments;
            }
            set
            {
                this.OnProductDocumentAttachmentsChanging(value);
                this._ProductDocumentAttachments = value;
                this.OnProductDocumentAttachmentsChanged();
                this.OnPropertyChanged("ProductDocumentAttachments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment> _ProductDocumentAttachments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductDocumentAttachmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductDocumentAttachment> value);
        partial void OnProductDocumentAttachmentsChanged();
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
