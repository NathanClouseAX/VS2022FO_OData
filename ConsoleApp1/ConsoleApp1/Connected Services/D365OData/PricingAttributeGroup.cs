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
    /// There are no comments for PricingAttributeGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PricingAttributeGroupSingle")]
    public partial class PricingAttributeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PricingAttributeGroup>
    {
        /// <summary>
        /// Initialize a new PricingAttributeGroupSingle object.
        /// </summary>
        public PricingAttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PricingAttributeGroupSingle object.
        /// </summary>
        public PricingAttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PricingAttributeGroupSingle object.
        /// </summary>
        public PricingAttributeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PricingAttributeGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for GUPPricingAttributeLink in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("GUPPricingAttributeLink")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink> GUPPricingAttributeLink
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GUPPricingAttributeLink == null))
                {
                    this._GUPPricingAttributeLink = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink>(GetPath("GUPPricingAttributeLink"));
                }
                return this._GUPPricingAttributeLink;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink> _GUPPricingAttributeLink;
    }
    /// <summary>
    /// There are no comments for PricingAttributeGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("PricingAttributeGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PricingAttributeGroup")]
    public partial class PricingAttributeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PricingAttributeGroup object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PricingAttributeGroup CreatePricingAttributeGroup(string name)
        {
            PricingAttributeGroup pricingAttributeGroup = new PricingAttributeGroup();
            pricingAttributeGroup.Name = name;
            return pricingAttributeGroup;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property IsValid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsValid")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsValid
        {
            get
            {
                return this._IsValid;
            }
            set
            {
                this.OnIsValidChanging(value);
                this._IsValid = value;
                this.OnIsValidChanged();
                this.OnPropertyChanged("IsValid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsValid;
        partial void OnIsValidChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsValidChanged();
        /// <summary>
        /// There are no comments for Property HelpText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HelpText")]
        public virtual string HelpText
        {
            get
            {
                return this._HelpText;
            }
            set
            {
                this.OnHelpTextChanging(value);
                this._HelpText = value;
                this.OnHelpTextChanged();
                this.OnPropertyChanged("HelpText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HelpText;
        partial void OnHelpTextChanging(string value);
        partial void OnHelpTextChanged();
        /// <summary>
        /// There are no comments for Property SourceLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceLevel")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPricingAttributeSourceLevel> SourceLevel
        {
            get
            {
                return this._SourceLevel;
            }
            set
            {
                this.OnSourceLevelChanging(value);
                this._SourceLevel = value;
                this.OnSourceLevelChanged();
                this.OnPropertyChanged("SourceLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPricingAttributeSourceLevel> _SourceLevel;
        partial void OnSourceLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPricingAttributeSourceLevel> value);
        partial void OnSourceLevelChanged();
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
        /// There are no comments for Property FriendlyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FriendlyName")]
        public virtual string FriendlyName
        {
            get
            {
                return this._FriendlyName;
            }
            set
            {
                this.OnFriendlyNameChanging(value);
                this._FriendlyName = value;
                this.OnFriendlyNameChanged();
                this.OnPropertyChanged("FriendlyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FriendlyName;
        partial void OnFriendlyNameChanging(string value);
        partial void OnFriendlyNameChanged();
        /// <summary>
        /// There are no comments for Property GUPPricingAttributeLink in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GUPPricingAttributeLink")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink> GUPPricingAttributeLink
        {
            get
            {
                return this._GUPPricingAttributeLink;
            }
            set
            {
                this.OnGUPPricingAttributeLinkChanging(value);
                this._GUPPricingAttributeLink = value;
                this.OnGUPPricingAttributeLinkChanged();
                this.OnPropertyChanged("GUPPricingAttributeLink");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink> _GUPPricingAttributeLink = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnGUPPricingAttributeLinkChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PricingAttributeLink> value);
        partial void OnGUPPricingAttributeLinkChanged();
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
