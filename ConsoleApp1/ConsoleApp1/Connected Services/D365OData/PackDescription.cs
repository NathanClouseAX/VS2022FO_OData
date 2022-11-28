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
    /// There are no comments for PackDescriptionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PackDescriptionSingle")]
    public partial class PackDescriptionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PackDescription>
    {
        /// <summary>
        /// Initialize a new PackDescriptionSingle object.
        /// </summary>
        public PackDescriptionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PackDescriptionSingle object.
        /// </summary>
        public PackDescriptionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PackDescriptionSingle object.
        /// </summary>
        public PackDescriptionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PackDescription> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PackDescription in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PackCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PackCode")]
    [global::Microsoft.OData.Client.EntitySet("PackDescriptions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PackDescription")]
    public partial class PackDescription : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PackDescription object.
        /// </summary>
        /// <param name="packCode">Initial value of PackCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PackDescription CreatePackDescription(string packCode)
        {
            PackDescription packDescription = new PackDescription();
            packDescription.PackCode = packCode;
            return packDescription;
        }
        /// <summary>
        /// There are no comments for Property PackCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PackCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PackCode is required.")]
        public virtual string PackCode
        {
            get
            {
                return this._PackCode;
            }
            set
            {
                this.OnPackCodeChanging(value);
                this._PackCode = value;
                this.OnPackCodeChanged();
                this.OnPropertyChanged("PackCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackCode;
        partial void OnPackCodeChanging(string value);
        partial void OnPackCodeChanged();
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