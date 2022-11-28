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
    /// There are no comments for CustomerChangeProposalFieldEnablementSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerChangeProposalFieldEnablementSingle")]
    public partial class CustomerChangeProposalFieldEnablementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerChangeProposalFieldEnablement>
    {
        /// <summary>
        /// Initialize a new CustomerChangeProposalFieldEnablementSingle object.
        /// </summary>
        public CustomerChangeProposalFieldEnablementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerChangeProposalFieldEnablementSingle object.
        /// </summary>
        public CustomerChangeProposalFieldEnablementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerChangeProposalFieldEnablementSingle object.
        /// </summary>
        public CustomerChangeProposalFieldEnablementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerChangeProposalFieldEnablement> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CustomerChangeProposalFieldEnablement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Field
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Field")]
    [global::Microsoft.OData.Client.EntitySet("CustomerChangeProposalFieldEnablements")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerChangeProposalFieldEnablement")]
    public partial class CustomerChangeProposalFieldEnablement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerChangeProposalFieldEnablement object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerChangeProposalFieldEnablement CreateCustomerChangeProposalFieldEnablement(string dataAreaId)
        {
            CustomerChangeProposalFieldEnablement customerChangeProposalFieldEnablement = new CustomerChangeProposalFieldEnablement();
            customerChangeProposalFieldEnablement.DataAreaId = dataAreaId;
            return customerChangeProposalFieldEnablement;
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
        /// There are no comments for Property Field in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Field")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustTableChangeProposalField> Field
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustTableChangeProposalField> _Field;
        partial void OnFieldChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustTableChangeProposalField> value);
        partial void OnFieldChanged();
        /// <summary>
        /// There are no comments for Property IsEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsEnabled
        {
            get
            {
                return this._IsEnabled;
            }
            set
            {
                this.OnIsEnabledChanging(value);
                this._IsEnabled = value;
                this.OnIsEnabledChanged();
                this.OnPropertyChanged("IsEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsEnabled;
        partial void OnIsEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsEnabledChanged();
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
