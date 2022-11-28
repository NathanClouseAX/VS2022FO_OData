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
    /// There are no comments for DimAttributeFiscalEstablishment_BRSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DimAttributeFiscalEstablishment_BRSingle")]
    public partial class DimAttributeFiscalEstablishment_BRSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DimAttributeFiscalEstablishment_BR>
    {
        /// <summary>
        /// Initialize a new DimAttributeFiscalEstablishment_BRSingle object.
        /// </summary>
        public DimAttributeFiscalEstablishment_BRSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DimAttributeFiscalEstablishment_BRSingle object.
        /// </summary>
        public DimAttributeFiscalEstablishment_BRSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DimAttributeFiscalEstablishment_BRSingle object.
        /// </summary>
        public DimAttributeFiscalEstablishment_BRSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DimAttributeFiscalEstablishment_BR> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DimAttributeFiscalEstablishment_BR in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Value
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Value")]
    [global::Microsoft.OData.Client.EntitySet("DimAttributeFiscalEstablishments_BR")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DimAttributeFiscalEstablishment_BR")]
    public partial class DimAttributeFiscalEstablishment_BR : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DimAttributeFiscalEstablishment_BR object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DimAttributeFiscalEstablishment_BR CreateDimAttributeFiscalEstablishment_BR(string dataAreaId, string value)
        {
            DimAttributeFiscalEstablishment_BR dimAttributeFiscalEstablishment_BR = new DimAttributeFiscalEstablishment_BR();
            dimAttributeFiscalEstablishment_BR.DataAreaId = dataAreaId;
            dimAttributeFiscalEstablishment_BR.Value = value;
            return dimAttributeFiscalEstablishment_BR;
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
