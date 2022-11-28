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
    /// There are no comments for CDSCustomerContactPersonSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CDSCustomerContactPersonSingle")]
    public partial class CDSCustomerContactPersonSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CDSCustomerContactPerson>
    {
        /// <summary>
        /// Initialize a new CDSCustomerContactPersonSingle object.
        /// </summary>
        public CDSCustomerContactPersonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CDSCustomerContactPersonSingle object.
        /// </summary>
        public CDSCustomerContactPersonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CDSCustomerContactPersonSingle object.
        /// </summary>
        public CDSCustomerContactPersonSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CDSCustomerContactPerson> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CDSCustomerContactPerson in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ContactPersonPartyNumber
    /// CustomerAccountNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ContactPersonPartyNumber", "CustomerAccountNumber")]
    [global::Microsoft.OData.Client.EntitySet("CDSCustomerContactPersons")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CDSCustomerContactPerson")]
    public partial class CDSCustomerContactPerson : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CDSCustomerContactPerson object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="contactPersonPartyNumber">Initial value of ContactPersonPartyNumber.</param>
        /// <param name="customerAccountNumber">Initial value of CustomerAccountNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CDSCustomerContactPerson CreateCDSCustomerContactPerson(string dataAreaId, string contactPersonPartyNumber, string customerAccountNumber)
        {
            CDSCustomerContactPerson cDSCustomerContactPerson = new CDSCustomerContactPerson();
            cDSCustomerContactPerson.DataAreaId = dataAreaId;
            cDSCustomerContactPerson.ContactPersonPartyNumber = contactPersonPartyNumber;
            cDSCustomerContactPerson.CustomerAccountNumber = customerAccountNumber;
            return cDSCustomerContactPerson;
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
        /// There are no comments for Property ContactPersonPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactPersonPartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ContactPersonPartyNumber is required.")]
        public virtual string ContactPersonPartyNumber
        {
            get
            {
                return this._ContactPersonPartyNumber;
            }
            set
            {
                this.OnContactPersonPartyNumberChanging(value);
                this._ContactPersonPartyNumber = value;
                this.OnContactPersonPartyNumberChanged();
                this.OnPropertyChanged("ContactPersonPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContactPersonPartyNumber;
        partial void OnContactPersonPartyNumberChanging(string value);
        partial void OnContactPersonPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccountNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerAccountNumber is required.")]
        public virtual string CustomerAccountNumber
        {
            get
            {
                return this._CustomerAccountNumber;
            }
            set
            {
                this.OnCustomerAccountNumberChanging(value);
                this._CustomerAccountNumber = value;
                this.OnCustomerAccountNumberChanged();
                this.OnPropertyChanged("CustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccountNumber;
        partial void OnCustomerAccountNumberChanging(string value);
        partial void OnCustomerAccountNumberChanged();
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