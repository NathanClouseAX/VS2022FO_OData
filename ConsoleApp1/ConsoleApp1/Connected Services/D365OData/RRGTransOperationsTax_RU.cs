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
    /// There are no comments for RRGTransOperationsTax_RUSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RRGTransOperationsTax_RUSingle")]
    public partial class RRGTransOperationsTax_RUSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RRGTransOperationsTax_RU>
    {
        /// <summary>
        /// Initialize a new RRGTransOperationsTax_RUSingle object.
        /// </summary>
        public RRGTransOperationsTax_RUSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RRGTransOperationsTax_RUSingle object.
        /// </summary>
        public RRGTransOperationsTax_RUSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RRGTransOperationsTax_RUSingle object.
        /// </summary>
        public RRGTransOperationsTax_RUSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RRGTransOperationsTax_RU> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RRGTransOperationsTax_RU in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OperationsTax
    /// RefTableName
    /// RefLineId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OperationsTax", "RefTableName", "RefLineId")]
    [global::Microsoft.OData.Client.EntitySet("RRGTransOperationsTax_RU")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RRGTransOperationsTax_RU")]
    public partial class RRGTransOperationsTax_RU : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RRGTransOperationsTax_RU object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="refTableName">Initial value of RefTableName.</param>
        /// <param name="refLineId">Initial value of RefLineId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RRGTransOperationsTax_RU CreateRRGTransOperationsTax_RU(string dataAreaId, string refTableName, string refLineId)
        {
            RRGTransOperationsTax_RU rRGTransOperationsTax_RU = new RRGTransOperationsTax_RU();
            rRGTransOperationsTax_RU.DataAreaId = dataAreaId;
            rRGTransOperationsTax_RU.RefTableName = refTableName;
            rRGTransOperationsTax_RU.RefLineId = refLineId;
            return rRGTransOperationsTax_RU;
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
        /// There are no comments for Property OperationsTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationsTax")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OperationsTax> OperationsTax
        {
            get
            {
                return this._OperationsTax;
            }
            set
            {
                this.OnOperationsTaxChanging(value);
                this._OperationsTax = value;
                this.OnOperationsTaxChanged();
                this.OnPropertyChanged("OperationsTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OperationsTax> _OperationsTax;
        partial void OnOperationsTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OperationsTax> value);
        partial void OnOperationsTaxChanged();
        /// <summary>
        /// There are no comments for Property RefTableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefTableName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefTableName is required.")]
        public virtual string RefTableName
        {
            get
            {
                return this._RefTableName;
            }
            set
            {
                this.OnRefTableNameChanging(value);
                this._RefTableName = value;
                this.OnRefTableNameChanged();
                this.OnPropertyChanged("RefTableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefTableName;
        partial void OnRefTableNameChanging(string value);
        partial void OnRefTableNameChanged();
        /// <summary>
        /// There are no comments for Property RefLineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefLineId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RefLineId is required.")]
        public virtual string RefLineId
        {
            get
            {
                return this._RefLineId;
            }
            set
            {
                this.OnRefLineIdChanging(value);
                this._RefLineId = value;
                this.OnRefLineIdChanged();
                this.OnPropertyChanged("RefLineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefLineId;
        partial void OnRefLineIdChanging(string value);
        partial void OnRefLineIdChanged();
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
