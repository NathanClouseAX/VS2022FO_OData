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
    /// There are no comments for PriceComponentCodeCombinationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeCombinationSingle")]
    public partial class PriceComponentCodeCombinationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PriceComponentCodeCombination>
    {
        /// <summary>
        /// Initialize a new PriceComponentCodeCombinationSingle object.
        /// </summary>
        public PriceComponentCodeCombinationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PriceComponentCodeCombinationSingle object.
        /// </summary>
        public PriceComponentCodeCombinationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PriceComponentCodeCombinationSingle object.
        /// </summary>
        public PriceComponentCodeCombinationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PriceComponentCodeCombination> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PriceComponentCodeCombination in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Name
    /// PriceAttributeGroupCombinationName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Name", "PriceAttributeGroupCombinationName")]
    [global::Microsoft.OData.Client.EntitySet("PriceComponentCodeCombinations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PriceComponentCodeCombination")]
    public partial class PriceComponentCodeCombination : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PriceComponentCodeCombination object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="priceAttributeGroupCombinationName">Initial value of PriceAttributeGroupCombinationName.</param>
        /// <param name="priority">Initial value of Priority.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PriceComponentCodeCombination CreatePriceComponentCodeCombination(string dataAreaId, string name, string priceAttributeGroupCombinationName, int priority)
        {
            PriceComponentCodeCombination priceComponentCodeCombination = new PriceComponentCodeCombination();
            priceComponentCodeCombination.DataAreaId = dataAreaId;
            priceComponentCodeCombination.Name = name;
            priceComponentCodeCombination.PriceAttributeGroupCombinationName = priceAttributeGroupCombinationName;
            priceComponentCodeCombination.Priority = priority;
            return priceComponentCodeCombination;
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
        /// There are no comments for Property PriceAttributeGroupCombinationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceAttributeGroupCombinationName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PriceAttributeGroupCombinationName is required.")]
        public virtual string PriceAttributeGroupCombinationName
        {
            get
            {
                return this._PriceAttributeGroupCombinationName;
            }
            set
            {
                this.OnPriceAttributeGroupCombinationNameChanging(value);
                this._PriceAttributeGroupCombinationName = value;
                this.OnPriceAttributeGroupCombinationNameChanged();
                this.OnPropertyChanged("PriceAttributeGroupCombinationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceAttributeGroupCombinationName;
        partial void OnPriceAttributeGroupCombinationNameChanging(string value);
        partial void OnPriceAttributeGroupCombinationNameChanged();
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
        /// There are no comments for Property HeaderGroupAll in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HeaderGroupAll")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPGroupAll> HeaderGroupAll
        {
            get
            {
                return this._HeaderGroupAll;
            }
            set
            {
                this.OnHeaderGroupAllChanging(value);
                this._HeaderGroupAll = value;
                this.OnHeaderGroupAllChanged();
                this.OnPropertyChanged("HeaderGroupAll");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPGroupAll> _HeaderGroupAll;
        partial void OnHeaderGroupAllChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPGroupAll> value);
        partial void OnHeaderGroupAllChanged();
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
        /// There are no comments for Property LinePriceAttributeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinePriceAttributeGroup")]
        public virtual string LinePriceAttributeGroup
        {
            get
            {
                return this._LinePriceAttributeGroup;
            }
            set
            {
                this.OnLinePriceAttributeGroupChanging(value);
                this._LinePriceAttributeGroup = value;
                this.OnLinePriceAttributeGroupChanged();
                this.OnPropertyChanged("LinePriceAttributeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinePriceAttributeGroup;
        partial void OnLinePriceAttributeGroupChanging(string value);
        partial void OnLinePriceAttributeGroupChanged();
        /// <summary>
        /// There are no comments for Property HeaderPriceAttributeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HeaderPriceAttributeGroup")]
        public virtual string HeaderPriceAttributeGroup
        {
            get
            {
                return this._HeaderPriceAttributeGroup;
            }
            set
            {
                this.OnHeaderPriceAttributeGroupChanging(value);
                this._HeaderPriceAttributeGroup = value;
                this.OnHeaderPriceAttributeGroupChanged();
                this.OnPropertyChanged("HeaderPriceAttributeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderPriceAttributeGroup;
        partial void OnHeaderPriceAttributeGroupChanging(string value);
        partial void OnHeaderPriceAttributeGroupChanged();
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
        /// There are no comments for Property LineGroupAll in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineGroupAll")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPGroupAll> LineGroupAll
        {
            get
            {
                return this._LineGroupAll;
            }
            set
            {
                this.OnLineGroupAllChanging(value);
                this._LineGroupAll = value;
                this.OnLineGroupAllChanged();
                this.OnPropertyChanged("LineGroupAll");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPGroupAll> _LineGroupAll;
        partial void OnLineGroupAllChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.GUPGroupAll> value);
        partial void OnLineGroupAllChanged();
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
