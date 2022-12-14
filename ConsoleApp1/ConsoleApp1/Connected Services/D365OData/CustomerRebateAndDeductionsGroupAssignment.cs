//------------------------------------------------------------------------------
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
    /// There are no comments for CustomerRebateAndDeductionsGroupAssignmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateAndDeductionsGroupAssignmentSingle")]
    public partial class CustomerRebateAndDeductionsGroupAssignmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerRebateAndDeductionsGroupAssignment>
    {
        /// <summary>
        /// Initialize a new CustomerRebateAndDeductionsGroupAssignmentSingle object.
        /// </summary>
        public CustomerRebateAndDeductionsGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerRebateAndDeductionsGroupAssignmentSingle object.
        /// </summary>
        public CustomerRebateAndDeductionsGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerRebateAndDeductionsGroupAssignmentSingle object.
        /// </summary>
        public CustomerRebateAndDeductionsGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerRebateAndDeductionsGroupAssignment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustomerRebateAndDeductionsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateAndDeductionsGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroupSingle CustomerRebateAndDeductionsGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerRebateAndDeductionsGroup == null))
                {
                    this._CustomerRebateAndDeductionsGroup = new global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroupSingle(this.Context, GetPath("CustomerRebateAndDeductionsGroup"));
                }
                return this._CustomerRebateAndDeductionsGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroupSingle _CustomerRebateAndDeductionsGroup;
        /// <summary>
        /// There are no comments for CustomerV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerV3")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3Single CustomerV3
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerV3 == null))
                {
                    this._CustomerV3 = new global::Microsoft.Dynamics.DataEntities.CustomerV3Single(this.Context, GetPath("CustomerV3"));
                }
                return this._CustomerV3;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3Single _CustomerV3;
    }
    /// <summary>
    /// There are no comments for CustomerRebateAndDeductionsGroupAssignment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CustomerRebateAndDeductionsGroupId
    /// CustomerAccountNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CustomerRebateAndDeductionsGroupId", "CustomerAccountNumber")]
    [global::Microsoft.OData.Client.EntitySet("CustomerRebateAndDeductionsGroupAssignments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateAndDeductionsGroupAssignment")]
    public partial class CustomerRebateAndDeductionsGroupAssignment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerRebateAndDeductionsGroupAssignment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="customerRebateAndDeductionsGroupId">Initial value of CustomerRebateAndDeductionsGroupId.</param>
        /// <param name="customerAccountNumber">Initial value of CustomerAccountNumber.</param>
        /// <param name="customerRebateAndDeductionsGroup">Initial value of CustomerRebateAndDeductionsGroup.</param>
        /// <param name="customerV3">Initial value of CustomerV3.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerRebateAndDeductionsGroupAssignment CreateCustomerRebateAndDeductionsGroupAssignment(string dataAreaId, string customerRebateAndDeductionsGroupId, string customerAccountNumber, global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroup customerRebateAndDeductionsGroup, global::Microsoft.Dynamics.DataEntities.CustomerV3 customerV3)
        {
            CustomerRebateAndDeductionsGroupAssignment customerRebateAndDeductionsGroupAssignment = new CustomerRebateAndDeductionsGroupAssignment();
            customerRebateAndDeductionsGroupAssignment.DataAreaId = dataAreaId;
            customerRebateAndDeductionsGroupAssignment.CustomerRebateAndDeductionsGroupId = customerRebateAndDeductionsGroupId;
            customerRebateAndDeductionsGroupAssignment.CustomerAccountNumber = customerAccountNumber;
            if ((customerRebateAndDeductionsGroup == null))
            {
                throw new global::System.ArgumentNullException("customerRebateAndDeductionsGroup");
            }
            customerRebateAndDeductionsGroupAssignment.CustomerRebateAndDeductionsGroup = customerRebateAndDeductionsGroup;
            if ((customerV3 == null))
            {
                throw new global::System.ArgumentNullException("customerV3");
            }
            customerRebateAndDeductionsGroupAssignment.CustomerV3 = customerV3;
            return customerRebateAndDeductionsGroupAssignment;
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
        /// There are no comments for Property CustomerRebateAndDeductionsGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateAndDeductionsGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerRebateAndDeductionsGroupId is required.")]
        public virtual string CustomerRebateAndDeductionsGroupId
        {
            get
            {
                return this._CustomerRebateAndDeductionsGroupId;
            }
            set
            {
                this.OnCustomerRebateAndDeductionsGroupIdChanging(value);
                this._CustomerRebateAndDeductionsGroupId = value;
                this.OnCustomerRebateAndDeductionsGroupIdChanged();
                this.OnPropertyChanged("CustomerRebateAndDeductionsGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerRebateAndDeductionsGroupId;
        partial void OnCustomerRebateAndDeductionsGroupIdChanging(string value);
        partial void OnCustomerRebateAndDeductionsGroupIdChanged();
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
        /// There are no comments for Property CustomerRebateAndDeductionsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateAndDeductionsGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerRebateAndDeductionsGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroup CustomerRebateAndDeductionsGroup
        {
            get
            {
                return this._CustomerRebateAndDeductionsGroup;
            }
            set
            {
                this.OnCustomerRebateAndDeductionsGroupChanging(value);
                this._CustomerRebateAndDeductionsGroup = value;
                this.OnCustomerRebateAndDeductionsGroupChanged();
                this.OnPropertyChanged("CustomerRebateAndDeductionsGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroup _CustomerRebateAndDeductionsGroup;
        partial void OnCustomerRebateAndDeductionsGroupChanging(global::Microsoft.Dynamics.DataEntities.CustomerRebateAndDeductionsGroup value);
        partial void OnCustomerRebateAndDeductionsGroupChanged();
        /// <summary>
        /// There are no comments for Property CustomerV3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerV3")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerV3 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3 CustomerV3
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
        private global::Microsoft.Dynamics.DataEntities.CustomerV3 _CustomerV3;
        partial void OnCustomerV3Changing(global::Microsoft.Dynamics.DataEntities.CustomerV3 value);
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
