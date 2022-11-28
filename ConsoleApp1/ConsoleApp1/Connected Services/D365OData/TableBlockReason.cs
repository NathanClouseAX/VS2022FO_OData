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
    /// There are no comments for TableBlockReasonSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TableBlockReasonSingle")]
    public partial class TableBlockReasonSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TableBlockReason>
    {
        /// <summary>
        /// Initialize a new TableBlockReasonSingle object.
        /// </summary>
        public TableBlockReasonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TableBlockReasonSingle object.
        /// </summary>
        public TableBlockReasonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TableBlockReasonSingle object.
        /// </summary>
        public TableBlockReasonSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TableBlockReason> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TableBlockReason in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CredManId
    /// Company
    /// Reason
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CredManId", "Company", "Reason")]
    [global::Microsoft.OData.Client.EntitySet("TableBlockReasons")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TableBlockReason")]
    public partial class TableBlockReason : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TableBlockReason object.
        /// </summary>
        /// <param name="credManId">Initial value of CredManId.</param>
        /// <param name="company">Initial value of Company.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TableBlockReason CreateTableBlockReason(string credManId, string company)
        {
            TableBlockReason tableBlockReason = new TableBlockReason();
            tableBlockReason.CredManId = credManId;
            tableBlockReason.Company = company;
            return tableBlockReason;
        }
        /// <summary>
        /// There are no comments for Property CredManId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CredManId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CredManId is required.")]
        public virtual string CredManId
        {
            get
            {
                return this._CredManId;
            }
            set
            {
                this.OnCredManIdChanging(value);
                this._CredManId = value;
                this.OnCredManIdChanged();
                this.OnPropertyChanged("CredManId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CredManId;
        partial void OnCredManIdChanging(string value);
        partial void OnCredManIdChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Company")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Company is required.")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property Reason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Reason")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CredManReason> Reason
        {
            get
            {
                return this._Reason;
            }
            set
            {
                this.OnReasonChanging(value);
                this._Reason = value;
                this.OnReasonChanged();
                this.OnPropertyChanged("Reason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CredManReason> _Reason;
        partial void OnReasonChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CredManReason> value);
        partial void OnReasonChanged();
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
