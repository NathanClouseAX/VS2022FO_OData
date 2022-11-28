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
    /// There are no comments for InternalOrganizationProductAttributeMetadataSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InternalOrganizationProductAttributeMetadataSingle")]
    public partial class InternalOrganizationProductAttributeMetadataSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InternalOrganizationProductAttributeMetadata>
    {
        /// <summary>
        /// Initialize a new InternalOrganizationProductAttributeMetadataSingle object.
        /// </summary>
        public InternalOrganizationProductAttributeMetadataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InternalOrganizationProductAttributeMetadataSingle object.
        /// </summary>
        public InternalOrganizationProductAttributeMetadataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InternalOrganizationProductAttributeMetadataSingle object.
        /// </summary>
        public InternalOrganizationProductAttributeMetadataSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InternalOrganizationProductAttributeMetadata> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for InternalOrganizationProductAttributeMetadata in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// AttributeName
    /// AttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "AttributeName", "AttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("InternalOrganizationProductAttributeMetadatas")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InternalOrganizationProductAttributeMetadata")]
    public partial class InternalOrganizationProductAttributeMetadata : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InternalOrganizationProductAttributeMetadata object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="attributeName">Initial value of AttributeName.</param>
        /// <param name="attributeTypeName">Initial value of AttributeTypeName.</param>
        /// <param name="xmlMetadataVersionNumber">Initial value of XmlMetadataVersionNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InternalOrganizationProductAttributeMetadata CreateInternalOrganizationProductAttributeMetadata(string partyNumber, string attributeName, string attributeTypeName, int xmlMetadataVersionNumber)
        {
            InternalOrganizationProductAttributeMetadata internalOrganizationProductAttributeMetadata = new InternalOrganizationProductAttributeMetadata();
            internalOrganizationProductAttributeMetadata.PartyNumber = partyNumber;
            internalOrganizationProductAttributeMetadata.AttributeName = attributeName;
            internalOrganizationProductAttributeMetadata.AttributeTypeName = attributeTypeName;
            internalOrganizationProductAttributeMetadata.XmlMetadataVersionNumber = xmlMetadataVersionNumber;
            return internalOrganizationProductAttributeMetadata;
        }
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartyNumber is required.")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property AttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeName is required.")]
        public virtual string AttributeName
        {
            get
            {
                return this._AttributeName;
            }
            set
            {
                this.OnAttributeNameChanging(value);
                this._AttributeName = value;
                this.OnAttributeNameChanged();
                this.OnPropertyChanged("AttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeName;
        partial void OnAttributeNameChanging(string value);
        partial void OnAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeTypeName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeTypeName is required.")]
        public virtual string AttributeTypeName
        {
            get
            {
                return this._AttributeTypeName;
            }
            set
            {
                this.OnAttributeTypeNameChanging(value);
                this._AttributeTypeName = value;
                this.OnAttributeTypeNameChanged();
                this.OnPropertyChanged("AttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeName;
        partial void OnAttributeTypeNameChanging(string value);
        partial void OnAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property OrganizationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationName")]
        public virtual string OrganizationName
        {
            get
            {
                return this._OrganizationName;
            }
            set
            {
                this.OnOrganizationNameChanging(value);
                this._OrganizationName = value;
                this.OnOrganizationNameChanged();
                this.OnPropertyChanged("OrganizationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationName;
        partial void OnOrganizationNameChanging(string value);
        partial void OnOrganizationNameChanged();
        /// <summary>
        /// There are no comments for Property XmlMetadata in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("XmlMetadata")]
        public virtual string XmlMetadata
        {
            get
            {
                return this._XmlMetadata;
            }
            set
            {
                this.OnXmlMetadataChanging(value);
                this._XmlMetadata = value;
                this.OnXmlMetadataChanged();
                this.OnPropertyChanged("XmlMetadata");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _XmlMetadata;
        partial void OnXmlMetadataChanging(string value);
        partial void OnXmlMetadataChanged();
        /// <summary>
        /// There are no comments for Property XmlMetadataVersionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("XmlMetadataVersionNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "XmlMetadataVersionNumber is required.")]
        public virtual int XmlMetadataVersionNumber
        {
            get
            {
                return this._XmlMetadataVersionNumber;
            }
            set
            {
                this.OnXmlMetadataVersionNumberChanging(value);
                this._XmlMetadataVersionNumber = value;
                this.OnXmlMetadataVersionNumberChanged();
                this.OnPropertyChanged("XmlMetadataVersionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _XmlMetadataVersionNumber;
        partial void OnXmlMetadataVersionNumberChanging(int value);
        partial void OnXmlMetadataVersionNumberChanged();
        /// <summary>
        /// There are no comments for Property AttributeRelationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeRelationType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailProductAttributeRelationType> AttributeRelationType
        {
            get
            {
                return this._AttributeRelationType;
            }
            set
            {
                this.OnAttributeRelationTypeChanging(value);
                this._AttributeRelationType = value;
                this.OnAttributeRelationTypeChanged();
                this.OnPropertyChanged("AttributeRelationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailProductAttributeRelationType> _AttributeRelationType;
        partial void OnAttributeRelationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailProductAttributeRelationType> value);
        partial void OnAttributeRelationTypeChanged();
        /// <summary>
        /// There are no comments for Property KeyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("KeyName")]
        public virtual string KeyName
        {
            get
            {
                return this._KeyName;
            }
            set
            {
                this.OnKeyNameChanging(value);
                this._KeyName = value;
                this.OnKeyNameChanged();
                this.OnPropertyChanged("KeyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KeyName;
        partial void OnKeyNameChanging(string value);
        partial void OnKeyNameChanged();
        /// <summary>
        /// There are no comments for Property IsRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsRequired
        {
            get
            {
                return this._IsRequired;
            }
            set
            {
                this.OnIsRequiredChanging(value);
                this._IsRequired = value;
                this.OnIsRequiredChanged();
                this.OnPropertyChanged("IsRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsRequired;
        partial void OnIsRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsRequiredChanged();
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