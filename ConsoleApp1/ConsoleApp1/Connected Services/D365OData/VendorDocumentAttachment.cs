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
    /// There are no comments for VendorDocumentAttachmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorDocumentAttachmentSingle")]
    public partial class VendorDocumentAttachmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorDocumentAttachment>
    {
        /// <summary>
        /// Initialize a new VendorDocumentAttachmentSingle object.
        /// </summary>
        public VendorDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorDocumentAttachmentSingle object.
        /// </summary>
        public VendorDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorDocumentAttachmentSingle object.
        /// </summary>
        public VendorDocumentAttachmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorDocumentAttachment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorDocumentAttachmentEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorDocumentAttachmentEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2Single VendorDocumentAttachmentEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorDocumentAttachmentEntity == null))
                {
                    this._VendorDocumentAttachmentEntity = new global::Microsoft.Dynamics.DataEntities.VendorV2Single(this.Context, GetPath("VendorDocumentAttachmentEntity"));
                }
                return this._VendorDocumentAttachmentEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2Single _VendorDocumentAttachmentEntity;
    }
    /// <summary>
    /// There are no comments for VendorDocumentAttachment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DocumentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentId")]
    [global::Microsoft.OData.Client.EntitySet("VendorDocumentAttachments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorDocumentAttachment")]
    public partial class VendorDocumentAttachment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorDocumentAttachment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        /// <param name="vendorDocumentAttachmentEntity">Initial value of VendorDocumentAttachmentEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorDocumentAttachment CreateVendorDocumentAttachment(string dataAreaId, global::System.Guid documentId, global::Microsoft.Dynamics.DataEntities.VendorV2 vendorDocumentAttachmentEntity)
        {
            VendorDocumentAttachment vendorDocumentAttachment = new VendorDocumentAttachment();
            vendorDocumentAttachment.DataAreaId = dataAreaId;
            vendorDocumentAttachment.DocumentId = documentId;
            if ((vendorDocumentAttachmentEntity == null))
            {
                throw new global::System.ArgumentNullException("vendorDocumentAttachmentEntity");
            }
            vendorDocumentAttachment.VendorDocumentAttachmentEntity = vendorDocumentAttachmentEntity;
            return vendorDocumentAttachment;
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
        /// There are no comments for Property DocumentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentId is required.")]
        public virtual global::System.Guid DocumentId
        {
            get
            {
                return this._DocumentId;
            }
            set
            {
                this.OnDocumentIdChanging(value);
                this._DocumentId = value;
                this.OnDocumentIdChanged();
                this.OnPropertyChanged("DocumentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _DocumentId;
        partial void OnDocumentIdChanging(global::System.Guid value);
        partial void OnDocumentIdChanged();
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
        /// There are no comments for Property VendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccountNumber")]
        public virtual string VendorAccountNumber
        {
            get
            {
                return this._VendorAccountNumber;
            }
            set
            {
                this.OnVendorAccountNumberChanging(value);
                this._VendorAccountNumber = value;
                this.OnVendorAccountNumberChanged();
                this.OnPropertyChanged("VendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccountNumber;
        partial void OnVendorAccountNumberChanging(string value);
        partial void OnVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property Attachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Attachment")]
        public virtual byte[] Attachment
        {
            get
            {
                return this._Attachment;
            }
            set
            {
                this.OnAttachmentChanging(value);
                this._Attachment = value;
                this.OnAttachmentChanged();
                this.OnPropertyChanged("Attachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _Attachment;
        partial void OnAttachmentChanging(byte[] value);
        partial void OnAttachmentChanged();
        /// <summary>
        /// There are no comments for Property DocumentAttachmentTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentAttachmentTypeCode")]
        public virtual string DocumentAttachmentTypeCode
        {
            get
            {
                return this._DocumentAttachmentTypeCode;
            }
            set
            {
                this.OnDocumentAttachmentTypeCodeChanging(value);
                this._DocumentAttachmentTypeCode = value;
                this.OnDocumentAttachmentTypeCodeChanged();
                this.OnPropertyChanged("DocumentAttachmentTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentAttachmentTypeCode;
        partial void OnDocumentAttachmentTypeCodeChanging(string value);
        partial void OnDocumentAttachmentTypeCodeChanged();
        /// <summary>
        /// There are no comments for Property AccessRestriction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccessRestriction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> AccessRestriction
        {
            get
            {
                return this._AccessRestriction;
            }
            set
            {
                this.OnAccessRestrictionChanging(value);
                this._AccessRestriction = value;
                this.OnAccessRestrictionChanged();
                this.OnPropertyChanged("AccessRestriction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> _AccessRestriction;
        partial void OnAccessRestrictionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DocuRestriction> value);
        partial void OnAccessRestrictionChanged();
        /// <summary>
        /// There are no comments for Property FileType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileType")]
        public virtual string FileType
        {
            get
            {
                return this._FileType;
            }
            set
            {
                this.OnFileTypeChanging(value);
                this._FileType = value;
                this.OnFileTypeChanged();
                this.OnPropertyChanged("FileType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileType;
        partial void OnFileTypeChanging(string value);
        partial void OnFileTypeChanged();
        /// <summary>
        /// There are no comments for Property AttachmentDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttachmentDescription")]
        public virtual string AttachmentDescription
        {
            get
            {
                return this._AttachmentDescription;
            }
            set
            {
                this.OnAttachmentDescriptionChanging(value);
                this._AttachmentDescription = value;
                this.OnAttachmentDescriptionChanged();
                this.OnPropertyChanged("AttachmentDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttachmentDescription;
        partial void OnAttachmentDescriptionChanging(string value);
        partial void OnAttachmentDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property IsDefaultAttachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefaultAttachment")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefaultAttachment
        {
            get
            {
                return this._IsDefaultAttachment;
            }
            set
            {
                this.OnIsDefaultAttachmentChanging(value);
                this._IsDefaultAttachment = value;
                this.OnIsDefaultAttachmentChanged();
                this.OnPropertyChanged("IsDefaultAttachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefaultAttachment;
        partial void OnIsDefaultAttachmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultAttachmentChanged();
        /// <summary>
        /// There are no comments for Property VendorDocumentAttachmentEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorDocumentAttachmentEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VendorDocumentAttachmentEntity is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2 VendorDocumentAttachmentEntity
        {
            get
            {
                return this._VendorDocumentAttachmentEntity;
            }
            set
            {
                this.OnVendorDocumentAttachmentEntityChanging(value);
                this._VendorDocumentAttachmentEntity = value;
                this.OnVendorDocumentAttachmentEntityChanged();
                this.OnPropertyChanged("VendorDocumentAttachmentEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2 _VendorDocumentAttachmentEntity;
        partial void OnVendorDocumentAttachmentEntityChanging(global::Microsoft.Dynamics.DataEntities.VendorV2 value);
        partial void OnVendorDocumentAttachmentEntityChanged();
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
