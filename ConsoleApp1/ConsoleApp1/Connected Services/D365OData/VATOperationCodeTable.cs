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
    /// There are no comments for VATOperationCodeTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VATOperationCodeTableSingle")]
    public partial class VATOperationCodeTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VATOperationCodeTable>
    {
        /// <summary>
        /// Initialize a new VATOperationCodeTableSingle object.
        /// </summary>
        public VATOperationCodeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VATOperationCodeTableSingle object.
        /// </summary>
        public VATOperationCodeTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VATOperationCodeTableSingle object.
        /// </summary>
        public VATOperationCodeTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VATOperationCodeTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VATOperationCodeTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// VATOperationCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VATOperationCode")]
    [global::Microsoft.OData.Client.EntitySet("VATOperationCodeTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VATOperationCodeTable")]
    public partial class VATOperationCodeTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VATOperationCodeTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="vATOperationCode">Initial value of VATOperationCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VATOperationCodeTable CreateVATOperationCodeTable(string dataAreaId, string vATOperationCode)
        {
            VATOperationCodeTable vATOperationCodeTable = new VATOperationCodeTable();
            vATOperationCodeTable.DataAreaId = dataAreaId;
            vATOperationCodeTable.VATOperationCode = vATOperationCode;
            return vATOperationCodeTable;
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
        /// There are no comments for Property VATOperationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATOperationCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VATOperationCode is required.")]
        public virtual string VATOperationCode
        {
            get
            {
                return this._VATOperationCode;
            }
            set
            {
                this.OnVATOperationCodeChanging(value);
                this._VATOperationCode = value;
                this.OnVATOperationCodeChanged();
                this.OnPropertyChanged("VATOperationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VATOperationCode;
        partial void OnVATOperationCodeChanging(string value);
        partial void OnVATOperationCodeChanged();
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