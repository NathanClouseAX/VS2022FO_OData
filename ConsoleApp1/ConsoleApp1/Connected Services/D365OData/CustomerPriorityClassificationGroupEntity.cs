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
    /// There are no comments for CustomerPriorityClassificationGroupEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPriorityClassificationGroupEntitySingle")]
    public partial class CustomerPriorityClassificationGroupEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPriorityClassificationGroupEntity>
    {
        /// <summary>
        /// Initialize a new CustomerPriorityClassificationGroupEntitySingle object.
        /// </summary>
        public CustomerPriorityClassificationGroupEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerPriorityClassificationGroupEntitySingle object.
        /// </summary>
        public CustomerPriorityClassificationGroupEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerPriorityClassificationGroupEntitySingle object.
        /// </summary>
        public CustomerPriorityClassificationGroupEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPriorityClassificationGroupEntity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustomerV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerV3")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerV3> CustomerV3
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerV3 == null))
                {
                    this._CustomerV3 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerV3>(GetPath("CustomerV3"));
                }
                return this._CustomerV3;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerV3> _CustomerV3;
    }
    /// <summary>
    /// There are no comments for CustomerPriorityClassificationGroupEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CustomerPriorityClassificationGroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CustomerPriorityClassificationGroupCode")]
    [global::Microsoft.OData.Client.EntitySet("CustomerPriorityClassificationGroup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPriorityClassificationGroupEntity")]
    public partial class CustomerPriorityClassificationGroupEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerPriorityClassificationGroupEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="customerPriorityClassificationGroupCode">Initial value of CustomerPriorityClassificationGroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerPriorityClassificationGroupEntity CreateCustomerPriorityClassificationGroupEntity(string dataAreaId, string customerPriorityClassificationGroupCode)
        {
            CustomerPriorityClassificationGroupEntity customerPriorityClassificationGroupEntity = new CustomerPriorityClassificationGroupEntity();
            customerPriorityClassificationGroupEntity.DataAreaId = dataAreaId;
            customerPriorityClassificationGroupEntity.CustomerPriorityClassificationGroupCode = customerPriorityClassificationGroupCode;
            return customerPriorityClassificationGroupEntity;
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
        /// There are no comments for Property CustomerPriorityClassificationGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPriorityClassificationGroupCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerPriorityClassificationGroupCode is required.")]
        public virtual string CustomerPriorityClassificationGroupCode
        {
            get
            {
                return this._CustomerPriorityClassificationGroupCode;
            }
            set
            {
                this.OnCustomerPriorityClassificationGroupCodeChanging(value);
                this._CustomerPriorityClassificationGroupCode = value;
                this.OnCustomerPriorityClassificationGroupCodeChanged();
                this.OnPropertyChanged("CustomerPriorityClassificationGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerPriorityClassificationGroupCode;
        partial void OnCustomerPriorityClassificationGroupCodeChanging(string value);
        partial void OnCustomerPriorityClassificationGroupCodeChanged();
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
        /// There are no comments for Property CustomerV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerV3")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerV3> CustomerV3
        {
            get
            {
                return this._CustomerV3;
            }
            set
            {
                this.OnCustomerV3Changing(value);
                this._CustomerV3 = value;
                this.OnCustomerV3Changed();
                this.OnPropertyChanged("CustomerV3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerV3> _CustomerV3 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerV3>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerV3Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerV3> value);
        partial void OnCustomerV3Changed();
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
