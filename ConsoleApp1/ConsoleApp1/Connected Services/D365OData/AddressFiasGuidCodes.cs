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
    /// There are no comments for AddressFiasGuidCodesSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressFiasGuidCodesSingle")]
    public partial class AddressFiasGuidCodesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressFiasGuidCodes>
    {
        /// <summary>
        /// Initialize a new AddressFiasGuidCodesSingle object.
        /// </summary>
        public AddressFiasGuidCodesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressFiasGuidCodesSingle object.
        /// </summary>
        public AddressFiasGuidCodesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressFiasGuidCodesSingle object.
        /// </summary>
        public AddressFiasGuidCodesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressFiasGuidCodes> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AddressFiasGuidCodes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FiasGuidId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FiasGuidId")]
    [global::Microsoft.OData.Client.EntitySet("AddressFiasGuidCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressFiasGuidCodes")]
    public partial class AddressFiasGuidCodes : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressFiasGuidCodes object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fiasGuidId">Initial value of FiasGuidId.</param>
        /// <param name="refTableId">Initial value of RefTableId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressFiasGuidCodes CreateAddressFiasGuidCodes(string dataAreaId, string fiasGuidId, int refTableId)
        {
            AddressFiasGuidCodes addressFiasGuidCodes = new AddressFiasGuidCodes();
            addressFiasGuidCodes.DataAreaId = dataAreaId;
            addressFiasGuidCodes.FiasGuidId = fiasGuidId;
            addressFiasGuidCodes.RefTableId = refTableId;
            return addressFiasGuidCodes;
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
        /// There are no comments for Property FiasGuidId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiasGuidId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiasGuidId is required.")]
        public virtual string FiasGuidId
        {
            get
            {
                return this._FiasGuidId;
            }
            set
            {
                this.OnFiasGuidIdChanging(value);
                this._FiasGuidId = value;
                this.OnFiasGuidIdChanged();
                this.OnPropertyChanged("FiasGuidId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiasGuidId;
        partial void OnFiasGuidIdChanging(string value);
        partial void OnFiasGuidIdChanged();
        /// <summary>
        /// There are no comments for Property FiasParentGuidId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiasParentGuidId")]
        public virtual string FiasParentGuidId
        {
            get
            {
                return this._FiasParentGuidId;
            }
            set
            {
                this.OnFiasParentGuidIdChanging(value);
                this._FiasParentGuidId = value;
                this.OnFiasParentGuidIdChanged();
                this.OnPropertyChanged("FiasParentGuidId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiasParentGuidId;
        partial void OnFiasParentGuidIdChanging(string value);
        partial void OnFiasParentGuidIdChanged();
        /// <summary>
        /// There are no comments for Property RefTableId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefTableId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefTableId is required.")]
        public virtual int RefTableId
        {
            get
            {
                return this._RefTableId;
            }
            set
            {
                this.OnRefTableIdChanging(value);
                this._RefTableId = value;
                this.OnRefTableIdChanged();
                this.OnPropertyChanged("RefTableId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RefTableId;
        partial void OnRefTableIdChanging(int value);
        partial void OnRefTableIdChanged();
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
