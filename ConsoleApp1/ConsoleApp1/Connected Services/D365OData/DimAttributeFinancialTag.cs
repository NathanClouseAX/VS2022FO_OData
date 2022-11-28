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
    /// There are no comments for DimAttributeFinancialTagSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DimAttributeFinancialTagSingle")]
    public partial class DimAttributeFinancialTagSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DimAttributeFinancialTag>
    {
        /// <summary>
        /// Initialize a new DimAttributeFinancialTagSingle object.
        /// </summary>
        public DimAttributeFinancialTagSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DimAttributeFinancialTagSingle object.
        /// </summary>
        public DimAttributeFinancialTagSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DimAttributeFinancialTagSingle object.
        /// </summary>
        public DimAttributeFinancialTagSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DimAttributeFinancialTag> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DimAttributeFinancialTag in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Value
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Value")]
    [global::Microsoft.OData.Client.EntitySet("DimAttributeFinancialTags")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DimAttributeFinancialTag")]
    public partial class DimAttributeFinancialTag : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DimAttributeFinancialTag object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DimAttributeFinancialTag CreateDimAttributeFinancialTag(string value)
        {
            DimAttributeFinancialTag dimAttributeFinancialTag = new DimAttributeFinancialTag();
            dimAttributeFinancialTag.Value = value;
            return dimAttributeFinancialTag;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Value is required.")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
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
        /// There are no comments for Property DimensionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionName")]
        public virtual string DimensionName
        {
            get
            {
                return this._DimensionName;
            }
            set
            {
                this.OnDimensionNameChanging(value);
                this._DimensionName = value;
                this.OnDimensionNameChanged();
                this.OnPropertyChanged("DimensionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionName;
        partial void OnDimensionNameChanging(string value);
        partial void OnDimensionNameChanged();
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