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
    /// There are no comments for HazardousMaterialLabelSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("HazardousMaterialLabelSingle")]
    public partial class HazardousMaterialLabelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<HazardousMaterialLabel>
    {
        /// <summary>
        /// Initialize a new HazardousMaterialLabelSingle object.
        /// </summary>
        public HazardousMaterialLabelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new HazardousMaterialLabelSingle object.
        /// </summary>
        public HazardousMaterialLabelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new HazardousMaterialLabelSingle object.
        /// </summary>
        public HazardousMaterialLabelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<HazardousMaterialLabel> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for HazardousMaterialLabel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LabelCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LabelCode")]
    [global::Microsoft.OData.Client.EntitySet("HazardousMaterialLabels")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("HazardousMaterialLabel")]
    public partial class HazardousMaterialLabel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new HazardousMaterialLabel object.
        /// </summary>
        /// <param name="labelCode">Initial value of LabelCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static HazardousMaterialLabel CreateHazardousMaterialLabel(string labelCode)
        {
            HazardousMaterialLabel hazardousMaterialLabel = new HazardousMaterialLabel();
            hazardousMaterialLabel.LabelCode = labelCode;
            return hazardousMaterialLabel;
        }
        /// <summary>
        /// There are no comments for Property LabelCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LabelCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LabelCode is required.")]
        public virtual string LabelCode
        {
            get
            {
                return this._LabelCode;
            }
            set
            {
                this.OnLabelCodeChanging(value);
                this._LabelCode = value;
                this.OnLabelCodeChanged();
                this.OnPropertyChanged("LabelCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LabelCode;
        partial void OnLabelCodeChanging(string value);
        partial void OnLabelCodeChanged();
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
