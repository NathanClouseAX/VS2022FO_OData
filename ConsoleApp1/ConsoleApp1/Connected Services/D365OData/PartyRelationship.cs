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
    /// There are no comments for PartyRelationshipSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartyRelationshipSingle")]
    public partial class PartyRelationshipSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PartyRelationship>
    {
        /// <summary>
        /// Initialize a new PartyRelationshipSingle object.
        /// </summary>
        public PartyRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PartyRelationshipSingle object.
        /// </summary>
        public PartyRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PartyRelationshipSingle object.
        /// </summary>
        public PartyRelationshipSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PartyRelationship> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DirRelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DirRelationshipType")]
        public virtual global::Microsoft.Dynamics.DataEntities.RelationshipTypeSingle DirRelationshipType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DirRelationshipType == null))
                {
                    this._DirRelationshipType = new global::Microsoft.Dynamics.DataEntities.RelationshipTypeSingle(this.Context, GetPath("DirRelationshipType"));
                }
                return this._DirRelationshipType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RelationshipTypeSingle _DirRelationshipType;
    }
    /// <summary>
    /// There are no comments for PartyRelationship in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RelationshipType
    /// ParentPartyId
    /// ChildPartyId
    /// LegalEntityDataArea
    /// ValidTo
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RelationshipType", "ParentPartyId", "ChildPartyId", "LegalEntityDataArea", "ValidTo", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("PartyRelationships")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartyRelationship")]
    public partial class PartyRelationship : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PartyRelationship object.
        /// </summary>
        /// <param name="relationshipType">Initial value of RelationshipType.</param>
        /// <param name="parentPartyId">Initial value of ParentPartyId.</param>
        /// <param name="childPartyId">Initial value of ChildPartyId.</param>
        /// <param name="legalEntityDataArea">Initial value of LegalEntityDataArea.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="dirRelationshipType">Initial value of DirRelationshipType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PartyRelationship CreatePartyRelationship(string relationshipType, 
                    string parentPartyId, 
                    string childPartyId, 
                    string legalEntityDataArea, 
                    global::System.DateTimeOffset validTo, 
                    global::System.DateTimeOffset validFrom, 
                    global::Microsoft.Dynamics.DataEntities.RelationshipType dirRelationshipType)
        {
            PartyRelationship partyRelationship = new PartyRelationship();
            partyRelationship.RelationshipType = relationshipType;
            partyRelationship.ParentPartyId = parentPartyId;
            partyRelationship.ChildPartyId = childPartyId;
            partyRelationship.LegalEntityDataArea = legalEntityDataArea;
            partyRelationship.ValidTo = validTo;
            partyRelationship.ValidFrom = validFrom;
            if ((dirRelationshipType == null))
            {
                throw new global::System.ArgumentNullException("dirRelationshipType");
            }
            partyRelationship.DirRelationshipType = dirRelationshipType;
            return partyRelationship;
        }
        /// <summary>
        /// There are no comments for Property RelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelationshipType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RelationshipType is required.")]
        public virtual string RelationshipType
        {
            get
            {
                return this._RelationshipType;
            }
            set
            {
                this.OnRelationshipTypeChanging(value);
                this._RelationshipType = value;
                this.OnRelationshipTypeChanged();
                this.OnPropertyChanged("RelationshipType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationshipType;
        partial void OnRelationshipTypeChanging(string value);
        partial void OnRelationshipTypeChanged();
        /// <summary>
        /// There are no comments for Property ParentPartyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentPartyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ParentPartyId is required.")]
        public virtual string ParentPartyId
        {
            get
            {
                return this._ParentPartyId;
            }
            set
            {
                this.OnParentPartyIdChanging(value);
                this._ParentPartyId = value;
                this.OnParentPartyIdChanged();
                this.OnPropertyChanged("ParentPartyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentPartyId;
        partial void OnParentPartyIdChanging(string value);
        partial void OnParentPartyIdChanged();
        /// <summary>
        /// There are no comments for Property ChildPartyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChildPartyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChildPartyId is required.")]
        public virtual string ChildPartyId
        {
            get
            {
                return this._ChildPartyId;
            }
            set
            {
                this.OnChildPartyIdChanging(value);
                this._ChildPartyId = value;
                this.OnChildPartyIdChanged();
                this.OnPropertyChanged("ChildPartyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChildPartyId;
        partial void OnChildPartyIdChanging(string value);
        partial void OnChildPartyIdChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityDataArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalEntityDataArea")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LegalEntityDataArea is required.")]
        public virtual string LegalEntityDataArea
        {
            get
            {
                return this._LegalEntityDataArea;
            }
            set
            {
                this.OnLegalEntityDataAreaChanging(value);
                this._LegalEntityDataArea = value;
                this.OnLegalEntityDataAreaChanged();
                this.OnPropertyChanged("LegalEntityDataArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityDataArea;
        partial void OnLegalEntityDataAreaChanging(string value);
        partial void OnLegalEntityDataAreaChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property DirRelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DirRelationshipType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DirRelationshipType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RelationshipType DirRelationshipType
        {
            get
            {
                return this._DirRelationshipType;
            }
            set
            {
                this.OnDirRelationshipTypeChanging(value);
                this._DirRelationshipType = value;
                this.OnDirRelationshipTypeChanged();
                this.OnPropertyChanged("DirRelationshipType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RelationshipType _DirRelationshipType;
        partial void OnDirRelationshipTypeChanging(global::Microsoft.Dynamics.DataEntities.RelationshipType value);
        partial void OnDirRelationshipTypeChanged();
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
