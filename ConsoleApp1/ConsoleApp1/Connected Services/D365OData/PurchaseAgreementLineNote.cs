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
    /// There are no comments for PurchaseAgreementLineNoteSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLineNoteSingle")]
    public partial class PurchaseAgreementLineNoteSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseAgreementLineNote>
    {
        /// <summary>
        /// Initialize a new PurchaseAgreementLineNoteSingle object.
        /// </summary>
        public PurchaseAgreementLineNoteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchaseAgreementLineNoteSingle object.
        /// </summary>
        public PurchaseAgreementLineNoteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchaseAgreementLineNoteSingle object.
        /// </summary>
        public PurchaseAgreementLineNoteSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseAgreementLineNote> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PurchaseAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLine")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineSingle PurchaseAgreementLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseAgreementLine == null))
                {
                    this._PurchaseAgreementLine = new global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineSingle(this.Context, GetPath("PurchaseAgreementLine"));
                }
                return this._PurchaseAgreementLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineSingle _PurchaseAgreementLine;
        /// <summary>
        /// There are no comments for PurchaseAgreementLineV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLineV2")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2Single PurchaseAgreementLineV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseAgreementLineV2 == null))
                {
                    this._PurchaseAgreementLineV2 = new global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2Single(this.Context, GetPath("PurchaseAgreementLineV2"));
                }
                return this._PurchaseAgreementLineV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2Single _PurchaseAgreementLineV2;
    }
    /// <summary>
    /// There are no comments for PurchaseAgreementLineNote in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PurchaseAgreementId
    /// LineNumber
    /// DocumentAttachmentTypeCode
    /// AttachmentDescription
    /// AttachedDateTime
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseAgreementId", "LineNumber", "DocumentAttachmentTypeCode", "AttachmentDescription", "AttachedDateTime")]
    [global::Microsoft.OData.Client.EntitySet("PurchaseAgreementLineNotes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLineNote")]
    public partial class PurchaseAgreementLineNote : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchaseAgreementLineNote object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="purchaseAgreementId">Initial value of PurchaseAgreementId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="documentAttachmentTypeCode">Initial value of DocumentAttachmentTypeCode.</param>
        /// <param name="attachmentDescription">Initial value of AttachmentDescription.</param>
        /// <param name="attachedDateTime">Initial value of AttachedDateTime.</param>
        /// <param name="purchaseAgreementLine">Initial value of PurchaseAgreementLine.</param>
        /// <param name="purchaseAgreementLineV2">Initial value of PurchaseAgreementLineV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchaseAgreementLineNote CreatePurchaseAgreementLineNote(string dataAreaId, 
                    string purchaseAgreementId, 
                    decimal lineNumber, 
                    string documentAttachmentTypeCode, 
                    string attachmentDescription, 
                    global::System.DateTimeOffset attachedDateTime, 
                    global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine purchaseAgreementLine, 
                    global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 purchaseAgreementLineV2)
        {
            PurchaseAgreementLineNote purchaseAgreementLineNote = new PurchaseAgreementLineNote();
            purchaseAgreementLineNote.DataAreaId = dataAreaId;
            purchaseAgreementLineNote.PurchaseAgreementId = purchaseAgreementId;
            purchaseAgreementLineNote.LineNumber = lineNumber;
            purchaseAgreementLineNote.DocumentAttachmentTypeCode = documentAttachmentTypeCode;
            purchaseAgreementLineNote.AttachmentDescription = attachmentDescription;
            purchaseAgreementLineNote.AttachedDateTime = attachedDateTime;
            if ((purchaseAgreementLine == null))
            {
                throw new global::System.ArgumentNullException("purchaseAgreementLine");
            }
            purchaseAgreementLineNote.PurchaseAgreementLine = purchaseAgreementLine;
            if ((purchaseAgreementLineV2 == null))
            {
                throw new global::System.ArgumentNullException("purchaseAgreementLineV2");
            }
            purchaseAgreementLineNote.PurchaseAgreementLineV2 = purchaseAgreementLineV2;
            return purchaseAgreementLineNote;
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
        /// There are no comments for Property PurchaseAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseAgreementId is required.")]
        public virtual string PurchaseAgreementId
        {
            get
            {
                return this._PurchaseAgreementId;
            }
            set
            {
                this.OnPurchaseAgreementIdChanging(value);
                this._PurchaseAgreementId = value;
                this.OnPurchaseAgreementIdChanged();
                this.OnPropertyChanged("PurchaseAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseAgreementId;
        partial void OnPurchaseAgreementIdChanging(string value);
        partial void OnPurchaseAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property DocumentAttachmentTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentAttachmentTypeCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentAttachmentTypeCode is required.")]
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
        /// There are no comments for Property AttachmentDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttachmentDescription")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttachmentDescription is required.")]
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
        /// There are no comments for Property AttachedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttachedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttachedDateTime is required.")]
        public virtual global::System.DateTimeOffset AttachedDateTime
        {
            get
            {
                return this._AttachedDateTime;
            }
            set
            {
                this.OnAttachedDateTimeChanging(value);
                this._AttachedDateTime = value;
                this.OnAttachedDateTimeChanged();
                this.OnPropertyChanged("AttachedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AttachedDateTime;
        partial void OnAttachedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnAttachedDateTimeChanged();
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
        /// There are no comments for Property AttachingUserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttachingUserId")]
        public virtual string AttachingUserId
        {
            get
            {
                return this._AttachingUserId;
            }
            set
            {
                this.OnAttachingUserIdChanging(value);
                this._AttachingUserId = value;
                this.OnAttachingUserIdChanged();
                this.OnPropertyChanged("AttachingUserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttachingUserId;
        partial void OnAttachingUserIdChanging(string value);
        partial void OnAttachingUserIdChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreementLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLegalEntityId")]
        public virtual string PurchaseAgreementLegalEntityId
        {
            get
            {
                return this._PurchaseAgreementLegalEntityId;
            }
            set
            {
                this.OnPurchaseAgreementLegalEntityIdChanging(value);
                this._PurchaseAgreementLegalEntityId = value;
                this.OnPurchaseAgreementLegalEntityIdChanged();
                this.OnPropertyChanged("PurchaseAgreementLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseAgreementLegalEntityId;
        partial void OnPurchaseAgreementLegalEntityIdChanging(string value);
        partial void OnPurchaseAgreementLegalEntityIdChanged();
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
        /// There are no comments for Property PurchaseAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLine")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseAgreementLine is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine PurchaseAgreementLine
        {
            get
            {
                return this._PurchaseAgreementLine;
            }
            set
            {
                this.OnPurchaseAgreementLineChanging(value);
                this._PurchaseAgreementLine = value;
                this.OnPurchaseAgreementLineChanged();
                this.OnPropertyChanged("PurchaseAgreementLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine _PurchaseAgreementLine;
        partial void OnPurchaseAgreementLineChanging(global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLine value);
        partial void OnPurchaseAgreementLineChanged();
        /// <summary>
        /// There are no comments for Property PurchaseAgreementLineV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseAgreementLineV2")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PurchaseAgreementLineV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 PurchaseAgreementLineV2
        {
            get
            {
                return this._PurchaseAgreementLineV2;
            }
            set
            {
                this.OnPurchaseAgreementLineV2Changing(value);
                this._PurchaseAgreementLineV2 = value;
                this.OnPurchaseAgreementLineV2Changed();
                this.OnPropertyChanged("PurchaseAgreementLineV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 _PurchaseAgreementLineV2;
        partial void OnPurchaseAgreementLineV2Changing(global::Microsoft.Dynamics.DataEntities.PurchaseAgreementLineV2 value);
        partial void OnPurchaseAgreementLineV2Changed();
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
