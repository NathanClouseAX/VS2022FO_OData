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
    /// There are no comments for ComponentectGroupAssignmentSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ComponentectGroupAssignmentSingle")]
    public partial class ComponentectGroupAssignmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ComponentectGroupAssignment>
    {
        /// <summary>
        /// Initialize a new ComponentectGroupAssignmentSingle object.
        /// </summary>
        public ComponentectGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ComponentectGroupAssignmentSingle object.
        /// </summary>
        public ComponentectGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ComponentectGroupAssignmentSingle object.
        /// </summary>
        public ComponentectGroupAssignmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ComponentectGroupAssignment> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ComponentectGroupAssignment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjectContractID
    /// CustomerAccount
    /// EffectiveFrom
    /// ProjectID
    /// Category
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjectContractID", "CustomerAccount", "EffectiveFrom", "ProjectID", "Category")]
    [global::Microsoft.OData.Client.EntitySet("ComponentectGroupAssignments")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ComponentectGroupAssignment")]
    public partial class ComponentectGroupAssignment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ComponentectGroupAssignment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="projectContractID">Initial value of ProjectContractID.</param>
        /// <param name="customerAccount">Initial value of CustomerAccount.</param>
        /// <param name="effectiveFrom">Initial value of EffectiveFrom.</param>
        /// <param name="projectID">Initial value of ProjectID.</param>
        /// <param name="category">Initial value of Category.</param>
        /// <param name="ruleSearchKey">Initial value of RuleSearchKey.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ComponentectGroupAssignment CreateComponentectGroupAssignment(string dataAreaId, 
                    string projectContractID, 
                    string customerAccount, 
                    global::System.DateTimeOffset effectiveFrom, 
                    string projectID, 
                    string category, 
                    long ruleSearchKey)
        {
            ComponentectGroupAssignment componentectGroupAssignment = new ComponentectGroupAssignment();
            componentectGroupAssignment.DataAreaId = dataAreaId;
            componentectGroupAssignment.ProjectContractID = projectContractID;
            componentectGroupAssignment.CustomerAccount = customerAccount;
            componentectGroupAssignment.EffectiveFrom = effectiveFrom;
            componentectGroupAssignment.ProjectID = projectID;
            componentectGroupAssignment.Category = category;
            componentectGroupAssignment.RuleSearchKey = ruleSearchKey;
            return componentectGroupAssignment;
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
        /// There are no comments for Property ProjectContractID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectContractID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectContractID is required.")]
        public virtual string ProjectContractID
        {
            get
            {
                return this._ProjectContractID;
            }
            set
            {
                this.OnProjectContractIDChanging(value);
                this._ProjectContractID = value;
                this.OnProjectContractIDChanged();
                this.OnPropertyChanged("ProjectContractID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectContractID;
        partial void OnProjectContractIDChanging(string value);
        partial void OnProjectContractIDChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CustomerAccount is required.")]
        public virtual string CustomerAccount
        {
            get
            {
                return this._CustomerAccount;
            }
            set
            {
                this.OnCustomerAccountChanging(value);
                this._CustomerAccount = value;
                this.OnCustomerAccountChanged();
                this.OnPropertyChanged("CustomerAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccount;
        partial void OnCustomerAccountChanging(string value);
        partial void OnCustomerAccountChanged();
        /// <summary>
        /// There are no comments for Property EffectiveFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EffectiveFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EffectiveFrom is required.")]
        public virtual global::System.DateTimeOffset EffectiveFrom
        {
            get
            {
                return this._EffectiveFrom;
            }
            set
            {
                this.OnEffectiveFromChanging(value);
                this._EffectiveFrom = value;
                this.OnEffectiveFromChanged();
                this.OnPropertyChanged("EffectiveFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveFrom;
        partial void OnEffectiveFromChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveFromChanged();
        /// <summary>
        /// There are no comments for Property ProjectID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjectID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjectID is required.")]
        public virtual string ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                this.OnProjectIDChanging(value);
                this._ProjectID = value;
                this.OnProjectIDChanged();
                this.OnPropertyChanged("ProjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectID;
        partial void OnProjectIDChanging(string value);
        partial void OnProjectIDChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Category is required.")]
        public virtual string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Category;
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property ResourcePersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResourcePersonnelNumber")]
        public virtual string ResourcePersonnelNumber
        {
            get
            {
                return this._ResourcePersonnelNumber;
            }
            set
            {
                this.OnResourcePersonnelNumberChanging(value);
                this._ResourcePersonnelNumber = value;
                this.OnResourcePersonnelNumberChanged();
                this.OnPropertyChanged("ResourcePersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourcePersonnelNumber;
        partial void OnResourcePersonnelNumberChanging(string value);
        partial void OnResourcePersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property IndirectCostComponentGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IndirectCostComponentGroup")]
        public virtual string IndirectCostComponentGroup
        {
            get
            {
                return this._IndirectCostComponentGroup;
            }
            set
            {
                this.OnIndirectCostComponentGroupChanging(value);
                this._IndirectCostComponentGroup = value;
                this.OnIndirectCostComponentGroupChanged();
                this.OnPropertyChanged("IndirectCostComponentGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IndirectCostComponentGroup;
        partial void OnIndirectCostComponentGroupChanging(string value);
        partial void OnIndirectCostComponentGroupChanged();
        /// <summary>
        /// There are no comments for Property RuleSearchKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleSearchKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleSearchKey is required.")]
        public virtual long RuleSearchKey
        {
            get
            {
                return this._RuleSearchKey;
            }
            set
            {
                this.OnRuleSearchKeyChanging(value);
                this._RuleSearchKey = value;
                this.OnRuleSearchKeyChanged();
                this.OnPropertyChanged("RuleSearchKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RuleSearchKey;
        partial void OnRuleSearchKeyChanging(long value);
        partial void OnRuleSearchKeyChanged();
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