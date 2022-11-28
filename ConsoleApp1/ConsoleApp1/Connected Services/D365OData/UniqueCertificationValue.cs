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
    /// There are no comments for UniqueCertificationValueSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UniqueCertificationValueSingle")]
    public partial class UniqueCertificationValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UniqueCertificationValue>
    {
        /// <summary>
        /// Initialize a new UniqueCertificationValueSingle object.
        /// </summary>
        public UniqueCertificationValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UniqueCertificationValueSingle object.
        /// </summary>
        public UniqueCertificationValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UniqueCertificationValueSingle object.
        /// </summary>
        public UniqueCertificationValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UniqueCertificationValue> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for UniqueCertificationValue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Field
    /// Value
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Field", "Value")]
    [global::Microsoft.OData.Client.EntitySet("UniqueCertificationValues")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UniqueCertificationValue")]
    public partial class UniqueCertificationValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UniqueCertificationValue object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UniqueCertificationValue CreateUniqueCertificationValue(string value)
        {
            UniqueCertificationValue uniqueCertificationValue = new UniqueCertificationValue();
            uniqueCertificationValue.Value = value;
            return uniqueCertificationValue;
        }
        /// <summary>
        /// There are no comments for Property Field in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Field")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UniqueCertificationFieldType_IT> Field
        {
            get
            {
                return this._Field;
            }
            set
            {
                this.OnFieldChanging(value);
                this._Field = value;
                this.OnFieldChanged();
                this.OnPropertyChanged("Field");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UniqueCertificationFieldType_IT> _Field;
        partial void OnFieldChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.UniqueCertificationFieldType_IT> value);
        partial void OnFieldChanged();
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
        /// There are no comments for Property Active in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Active")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Active;
        partial void OnActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnActiveChanged();
        /// <summary>
        /// There are no comments for Property ValueDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValueDescription")]
        public virtual string ValueDescription
        {
            get
            {
                return this._ValueDescription;
            }
            set
            {
                this.OnValueDescriptionChanging(value);
                this._ValueDescription = value;
                this.OnValueDescriptionChanged();
                this.OnPropertyChanged("ValueDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueDescription;
        partial void OnValueDescriptionChanging(string value);
        partial void OnValueDescriptionChanged();
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
