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
    /// There are no comments for RetailAssortmentProductLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailAssortmentProductLineSingle")]
    public partial class RetailAssortmentProductLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailAssortmentProductLine>
    {
        /// <summary>
        /// Initialize a new RetailAssortmentProductLineSingle object.
        /// </summary>
        public RetailAssortmentProductLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailAssortmentProductLineSingle object.
        /// </summary>
        public RetailAssortmentProductLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailAssortmentProductLineSingle object.
        /// </summary>
        public RetailAssortmentProductLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailAssortmentProductLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailAssortmentProductLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AssortmentId
    /// LineNumber
    /// Status
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AssortmentId", "LineNumber", "Status")]
    [global::Microsoft.OData.Client.EntitySet("RetailAssortmentProductLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailAssortmentProductLine")]
    public partial class RetailAssortmentProductLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailAssortmentProductLine object.
        /// </summary>
        /// <param name="assortmentId">Initial value of AssortmentId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailAssortmentProductLine CreateRetailAssortmentProductLine(string assortmentId, decimal lineNumber)
        {
            RetailAssortmentProductLine retailAssortmentProductLine = new RetailAssortmentProductLine();
            retailAssortmentProductLine.AssortmentId = assortmentId;
            retailAssortmentProductLine.LineNumber = lineNumber;
            return retailAssortmentProductLine;
        }
        /// <summary>
        /// There are no comments for Property AssortmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssortmentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssortmentId is required.")]
        public virtual string AssortmentId
        {
            get
            {
                return this._AssortmentId;
            }
            set
            {
                this.OnAssortmentIdChanging(value);
                this._AssortmentId = value;
                this.OnAssortmentIdChanged();
                this.OnPropertyChanged("AssortmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssortmentId;
        partial void OnAssortmentIdChanging(string value);
        partial void OnAssortmentIdChanged();
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAssortmentStatusType> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAssortmentStatusType> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAssortmentStatusType> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property LineType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAssortmentExcludeIncludeType> LineType
        {
            get
            {
                return this._LineType;
            }
            set
            {
                this.OnLineTypeChanging(value);
                this._LineType = value;
                this.OnLineTypeChanged();
                this.OnPropertyChanged("LineType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAssortmentExcludeIncludeType> _LineType;
        partial void OnLineTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAssortmentExcludeIncludeType> value);
        partial void OnLineTypeChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryHierarchyName")]
        public virtual string CategoryHierarchyName
        {
            get
            {
                return this._CategoryHierarchyName;
            }
            set
            {
                this.OnCategoryHierarchyNameChanging(value);
                this._CategoryHierarchyName = value;
                this.OnCategoryHierarchyNameChanged();
                this.OnPropertyChanged("CategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryHierarchyName;
        partial void OnCategoryHierarchyNameChanging(string value);
        partial void OnCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Size")]
        public virtual string Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("Size");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Size;
        partial void OnSizeChanging(string value);
        partial void OnSizeChanged();
        /// <summary>
        /// There are no comments for Property ConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfigurationId")]
        public virtual string ConfigurationId
        {
            get
            {
                return this._ConfigurationId;
            }
            set
            {
                this.OnConfigurationIdChanging(value);
                this._ConfigurationId = value;
                this.OnConfigurationIdChanged();
                this.OnPropertyChanged("ConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfigurationId;
        partial void OnConfigurationIdChanging(string value);
        partial void OnConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property Color in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Color")]
        public virtual string Color
        {
            get
            {
                return this._Color;
            }
            set
            {
                this.OnColorChanging(value);
                this._Color = value;
                this.OnColorChanged();
                this.OnPropertyChanged("Color");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Color;
        partial void OnColorChanging(string value);
        partial void OnColorChanged();
        /// <summary>
        /// There are no comments for Property SourceDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceDataAreaId")]
        public virtual string SourceDataAreaId
        {
            get
            {
                return this._SourceDataAreaId;
            }
            set
            {
                this.OnSourceDataAreaIdChanging(value);
                this._SourceDataAreaId = value;
                this.OnSourceDataAreaIdChanged();
                this.OnPropertyChanged("SourceDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceDataAreaId;
        partial void OnSourceDataAreaIdChanging(string value);
        partial void OnSourceDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property Style in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Style")]
        public virtual string Style
        {
            get
            {
                return this._Style;
            }
            set
            {
                this.OnStyleChanging(value);
                this._Style = value;
                this.OnStyleChanged();
                this.OnPropertyChanged("Style");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Style;
        partial void OnStyleChanging(string value);
        partial void OnStyleChanged();
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CategoryName")]
        public virtual string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this._CategoryName = value;
                this.OnCategoryNameChanged();
                this.OnPropertyChanged("CategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemId")]
        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
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
