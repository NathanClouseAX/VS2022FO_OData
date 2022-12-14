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
    /// There are no comments for PriceComponentCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeSingle")]
    public partial class PriceComponentCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PriceComponentCode>
    {
        /// <summary>
        /// Initialize a new PriceComponentCodeSingle object.
        /// </summary>
        public PriceComponentCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PriceComponentCodeSingle object.
        /// </summary>
        public PriceComponentCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PriceComponentCodeSingle object.
        /// </summary>
        public PriceComponentCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PriceComponentCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PriceComponentCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Name
    /// PriceAttributeGroup
    /// SourceLevel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name", "PriceAttributeGroup", "SourceLevel")]
    [global::Microsoft.OData.Client.EntitySet("PriceComponentCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCode")]
    public partial class PriceComponentCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PriceComponentCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="priceAttributeGroup">Initial value of PriceAttributeGroup.</param>
        /// <param name="priority">Initial value of Priority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PriceComponentCode CreatePriceComponentCode(string dataAreaId, string name, string priceAttributeGroup, int priority)
        {
            PriceComponentCode priceComponentCode = new PriceComponentCode();
            priceComponentCode.DataAreaId = dataAreaId;
            priceComponentCode.Name = name;
            priceComponentCode.PriceAttributeGroup = priceAttributeGroup;
            priceComponentCode.Priority = priority;
            return priceComponentCode;
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
        /// There are no comments for Property PriceAttributeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceAttributeGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceAttributeGroup is required.")]
        public virtual string PriceAttributeGroup
        {
            get
            {
                return this._PriceAttributeGroup;
            }
            set
            {
                this.OnPriceAttributeGroupChanging(value);
                this._PriceAttributeGroup = value;
                this.OnPriceAttributeGroupChanged();
                this.OnPropertyChanged("PriceAttributeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceAttributeGroup;
        partial void OnPriceAttributeGroupChanging(string value);
        partial void OnPriceAttributeGroupChanged();
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
        /// There are no comments for Property PriceComponentCodeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeGroup")]
        public virtual string PriceComponentCodeGroup
        {
            get
            {
                return this._PriceComponentCodeGroup;
            }
            set
            {
                this.OnPriceComponentCodeGroupChanging(value);
                this._PriceComponentCodeGroup = value;
                this.OnPriceComponentCodeGroupChanged();
                this.OnPropertyChanged("PriceComponentCodeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceComponentCodeGroup;
        partial void OnPriceComponentCodeGroupChanging(string value);
        partial void OnPriceComponentCodeGroupChanged();
        /// <summary>
        /// There are no comments for Property PriceComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponent")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceComponent> PriceComponent
        {
            get
            {
                return this._PriceComponent;
            }
            set
            {
                this.OnPriceComponentChanging(value);
                this._PriceComponent = value;
                this.OnPriceComponentChanged();
                this.OnPropertyChanged("PriceComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceComponent> _PriceComponent;
        partial void OnPriceComponentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPPriceComponent> value);
        partial void OnPriceComponentChanged();
        /// <summary>
        /// There are no comments for Property ConcurrencyMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConcurrencyMode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDiscountConcurrency> ConcurrencyMode
        {
            get
            {
                return this._ConcurrencyMode;
            }
            set
            {
                this.OnConcurrencyModeChanging(value);
                this._ConcurrencyMode = value;
                this.OnConcurrencyModeChanged();
                this.OnPropertyChanged("ConcurrencyMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDiscountConcurrency> _ConcurrencyMode;
        partial void OnConcurrencyModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDiscountConcurrency> value);
        partial void OnConcurrencyModeChanged();
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
        /// There are no comments for Property Priority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Priority")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Priority is required.")]
        public virtual int Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                this.OnPriorityChanging(value);
                this._Priority = value;
                this.OnPriorityChanged();
                this.OnPropertyChanged("Priority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Priority;
        partial void OnPriorityChanging(int value);
        partial void OnPriorityChanged();
        /// <summary>
        /// There are no comments for Property HeaderPriceAttributeGroupAllEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HeaderPriceAttributeGroupAllEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> HeaderPriceAttributeGroupAllEnabled
        {
            get
            {
                return this._HeaderPriceAttributeGroupAllEnabled;
            }
            set
            {
                this.OnHeaderPriceAttributeGroupAllEnabledChanging(value);
                this._HeaderPriceAttributeGroupAllEnabled = value;
                this.OnHeaderPriceAttributeGroupAllEnabledChanged();
                this.OnPropertyChanged("HeaderPriceAttributeGroupAllEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _HeaderPriceAttributeGroupAllEnabled;
        partial void OnHeaderPriceAttributeGroupAllEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnHeaderPriceAttributeGroupAllEnabledChanged();
        /// <summary>
        /// There are no comments for Property LinePriceAttributeGroupAllEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinePriceAttributeGroupAllEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> LinePriceAttributeGroupAllEnabled
        {
            get
            {
                return this._LinePriceAttributeGroupAllEnabled;
            }
            set
            {
                this.OnLinePriceAttributeGroupAllEnabledChanging(value);
                this._LinePriceAttributeGroupAllEnabled = value;
                this.OnLinePriceAttributeGroupAllEnabledChanged();
                this.OnPropertyChanged("LinePriceAttributeGroupAllEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _LinePriceAttributeGroupAllEnabled;
        partial void OnLinePriceAttributeGroupAllEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLinePriceAttributeGroupAllEnabledChanged();
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
