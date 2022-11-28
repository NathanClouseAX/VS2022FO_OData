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
    /// There are no comments for CustomerHierarchyNodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerHierarchyNodeSingle")]
    public partial class CustomerHierarchyNodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerHierarchyNode>
    {
        /// <summary>
        /// Initialize a new CustomerHierarchyNodeSingle object.
        /// </summary>
        public CustomerHierarchyNodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerHierarchyNodeSingle object.
        /// </summary>
        public CustomerHierarchyNodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerHierarchyNodeSingle object.
        /// </summary>
        public CustomerHierarchyNodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerHierarchyNode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustomerHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerHierarchy")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerHierarchySingle CustomerHierarchy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerHierarchy == null))
                {
                    this._CustomerHierarchy = new global::Microsoft.Dynamics.DataEntities.CustomerHierarchySingle(this.Context, GetPath("CustomerHierarchy"));
                }
                return this._CustomerHierarchy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerHierarchySingle _CustomerHierarchy;
        /// <summary>
        /// There are no comments for CDSParty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CDSParty")]
        public virtual global::Microsoft.Dynamics.DataEntities.CDSPartySingle CDSParty
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CDSParty == null))
                {
                    this._CDSParty = new global::Microsoft.Dynamics.DataEntities.CDSPartySingle(this.Context, GetPath("CDSParty"));
                }
                return this._CDSParty;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CDSPartySingle _CDSParty;
    }
    /// <summary>
    /// There are no comments for CustomerHierarchyNode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerHierarchyId
    /// NodePartyNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CustomerHierarchyId", "NodePartyNumber")]
    [global::Microsoft.OData.Client.EntitySet("CustomerHierarchyNodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerHierarchyNode")]
    public partial class CustomerHierarchyNode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerHierarchyNode object.
        /// </summary>
        /// <param name="customerHierarchyId">Initial value of CustomerHierarchyId.</param>
        /// <param name="nodePartyNumber">Initial value of NodePartyNumber.</param>
        /// <param name="versionAdded">Initial value of VersionAdded.</param>
        /// <param name="versionRemoved">Initial value of VersionRemoved.</param>
        /// <param name="customerHierarchy">Initial value of CustomerHierarchy.</param>
        /// <param name="cDSParty">Initial value of CDSParty.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerHierarchyNode CreateCustomerHierarchyNode(string customerHierarchyId, 
                    string nodePartyNumber, 
                    int versionAdded, 
                    int versionRemoved, 
                    global::Microsoft.Dynamics.DataEntities.CustomerHierarchy customerHierarchy, 
                    global::Microsoft.Dynamics.DataEntities.CDSParty cDSParty)
        {
            CustomerHierarchyNode customerHierarchyNode = new CustomerHierarchyNode();
            customerHierarchyNode.CustomerHierarchyId = customerHierarchyId;
            customerHierarchyNode.NodePartyNumber = nodePartyNumber;
            customerHierarchyNode.VersionAdded = versionAdded;
            customerHierarchyNode.VersionRemoved = versionRemoved;
            if ((customerHierarchy == null))
            {
                throw new global::System.ArgumentNullException("customerHierarchy");
            }
            customerHierarchyNode.CustomerHierarchy = customerHierarchy;
            if ((cDSParty == null))
            {
                throw new global::System.ArgumentNullException("cDSParty");
            }
            customerHierarchyNode.CDSParty = cDSParty;
            return customerHierarchyNode;
        }
        /// <summary>
        /// There are no comments for Property CustomerHierarchyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerHierarchyId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerHierarchyId is required.")]
        public virtual string CustomerHierarchyId
        {
            get
            {
                return this._CustomerHierarchyId;
            }
            set
            {
                this.OnCustomerHierarchyIdChanging(value);
                this._CustomerHierarchyId = value;
                this.OnCustomerHierarchyIdChanged();
                this.OnPropertyChanged("CustomerHierarchyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerHierarchyId;
        partial void OnCustomerHierarchyIdChanging(string value);
        partial void OnCustomerHierarchyIdChanged();
        /// <summary>
        /// There are no comments for Property NodePartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NodePartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NodePartyNumber is required.")]
        public virtual string NodePartyNumber
        {
            get
            {
                return this._NodePartyNumber;
            }
            set
            {
                this.OnNodePartyNumberChanging(value);
                this._NodePartyNumber = value;
                this.OnNodePartyNumberChanged();
                this.OnPropertyChanged("NodePartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NodePartyNumber;
        partial void OnNodePartyNumberChanging(string value);
        partial void OnNodePartyNumberChanged();
        /// <summary>
        /// There are no comments for Property NodeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NodeType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustHierarchyNodeType> NodeType
        {
            get
            {
                return this._NodeType;
            }
            set
            {
                this.OnNodeTypeChanging(value);
                this._NodeType = value;
                this.OnNodeTypeChanged();
                this.OnPropertyChanged("NodeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustHierarchyNodeType> _NodeType;
        partial void OnNodeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustHierarchyNodeType> value);
        partial void OnNodeTypeChanged();
        /// <summary>
        /// There are no comments for Property VersionAdded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VersionAdded")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VersionAdded is required.")]
        public virtual int VersionAdded
        {
            get
            {
                return this._VersionAdded;
            }
            set
            {
                this.OnVersionAddedChanging(value);
                this._VersionAdded = value;
                this.OnVersionAddedChanged();
                this.OnPropertyChanged("VersionAdded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _VersionAdded;
        partial void OnVersionAddedChanging(int value);
        partial void OnVersionAddedChanged();
        /// <summary>
        /// There are no comments for Property VersionRemoved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VersionRemoved")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VersionRemoved is required.")]
        public virtual int VersionRemoved
        {
            get
            {
                return this._VersionRemoved;
            }
            set
            {
                this.OnVersionRemovedChanging(value);
                this._VersionRemoved = value;
                this.OnVersionRemovedChanged();
                this.OnPropertyChanged("VersionRemoved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _VersionRemoved;
        partial void OnVersionRemovedChanging(int value);
        partial void OnVersionRemovedChanged();
        /// <summary>
        /// There are no comments for Property Role in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Role")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustHierarchyNodeRole> Role
        {
            get
            {
                return this._Role;
            }
            set
            {
                this.OnRoleChanging(value);
                this._Role = value;
                this.OnRoleChanged();
                this.OnPropertyChanged("Role");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustHierarchyNodeRole> _Role;
        partial void OnRoleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustHierarchyNodeRole> value);
        partial void OnRoleChanged();
        /// <summary>
        /// There are no comments for Property CustomerHierarchy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerHierarchy")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerHierarchy is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerHierarchy CustomerHierarchy
        {
            get
            {
                return this._CustomerHierarchy;
            }
            set
            {
                this.OnCustomerHierarchyChanging(value);
                this._CustomerHierarchy = value;
                this.OnCustomerHierarchyChanged();
                this.OnPropertyChanged("CustomerHierarchy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerHierarchy _CustomerHierarchy;
        partial void OnCustomerHierarchyChanging(global::Microsoft.Dynamics.DataEntities.CustomerHierarchy value);
        partial void OnCustomerHierarchyChanged();
        /// <summary>
        /// There are no comments for Property CDSParty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CDSParty")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CDSParty is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CDSParty CDSParty
        {
            get
            {
                return this._CDSParty;
            }
            set
            {
                this.OnCDSPartyChanging(value);
                this._CDSParty = value;
                this.OnCDSPartyChanged();
                this.OnPropertyChanged("CDSParty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CDSParty _CDSParty;
        partial void OnCDSPartyChanging(global::Microsoft.Dynamics.DataEntities.CDSParty value);
        partial void OnCDSPartyChanged();
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
