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
    /// There are no comments for RetailDirAddressBookPartySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDirAddressBookPartySingle")]
    public partial class RetailDirAddressBookPartySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDirAddressBookParty>
    {
        /// <summary>
        /// Initialize a new RetailDirAddressBookPartySingle object.
        /// </summary>
        public RetailDirAddressBookPartySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailDirAddressBookPartySingle object.
        /// </summary>
        public RetailDirAddressBookPartySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailDirAddressBookPartySingle object.
        /// </summary>
        public RetailDirAddressBookPartySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDirAddressBookParty> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailDirAddressBookParty in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AddressBookName
    /// PartyNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AddressBookName", "PartyNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailDirAddressBookParties")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDirAddressBookParty")]
    public partial class RetailDirAddressBookParty : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailDirAddressBookParty object.
        /// </summary>
        /// <param name="addressBookName">Initial value of AddressBookName.</param>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="addressBookRecordId">Initial value of AddressBookRecordId.</param>
        /// <param name="partyRecordId">Initial value of PartyRecordId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailDirAddressBookParty CreateRetailDirAddressBookParty(string addressBookName, string partyNumber, long addressBookRecordId, long partyRecordId)
        {
            RetailDirAddressBookParty retailDirAddressBookParty = new RetailDirAddressBookParty();
            retailDirAddressBookParty.AddressBookName = addressBookName;
            retailDirAddressBookParty.PartyNumber = partyNumber;
            retailDirAddressBookParty.AddressBookRecordId = addressBookRecordId;
            retailDirAddressBookParty.PartyRecordId = partyRecordId;
            return retailDirAddressBookParty;
        }
        /// <summary>
        /// There are no comments for Property AddressBookName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressBookName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AddressBookName is required.")]
        public virtual string AddressBookName
        {
            get
            {
                return this._AddressBookName;
            }
            set
            {
                this.OnAddressBookNameChanging(value);
                this._AddressBookName = value;
                this.OnAddressBookNameChanged();
                this.OnPropertyChanged("AddressBookName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressBookName;
        partial void OnAddressBookNameChanging(string value);
        partial void OnAddressBookNameChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartyNumber is required.")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property AddressBookRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressBookRecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AddressBookRecordId is required.")]
        public virtual long AddressBookRecordId
        {
            get
            {
                return this._AddressBookRecordId;
            }
            set
            {
                this.OnAddressBookRecordIdChanging(value);
                this._AddressBookRecordId = value;
                this.OnAddressBookRecordIdChanged();
                this.OnPropertyChanged("AddressBookRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _AddressBookRecordId;
        partial void OnAddressBookRecordIdChanging(long value);
        partial void OnAddressBookRecordIdChanged();
        /// <summary>
        /// There are no comments for Property PartyRecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyRecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartyRecordId is required.")]
        public virtual long PartyRecordId
        {
            get
            {
                return this._PartyRecordId;
            }
            set
            {
                this.OnPartyRecordIdChanging(value);
                this._PartyRecordId = value;
                this.OnPartyRecordIdChanged();
                this.OnPropertyChanged("PartyRecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _PartyRecordId;
        partial void OnPartyRecordIdChanging(long value);
        partial void OnPartyRecordIdChanged();
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
