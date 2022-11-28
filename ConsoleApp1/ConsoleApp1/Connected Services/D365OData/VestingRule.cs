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
    /// There are no comments for VestingRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VestingRuleSingle")]
    public partial class VestingRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VestingRule>
    {
        /// <summary>
        /// Initialize a new VestingRuleSingle object.
        /// </summary>
        public VestingRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VestingRuleSingle object.
        /// </summary>
        public VestingRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VestingRuleSingle object.
        /// </summary>
        public VestingRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VestingRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompVarPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanTable")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable> CompVarPlanTable
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompVarPlanTable == null))
                {
                    this._CompVarPlanTable = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable>(GetPath("CompVarPlanTable"));
                }
                return this._CompVarPlanTable;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable> _CompVarPlanTable;
    }
    /// <summary>
    /// There are no comments for VestingRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// VestingRule
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VestingRule")]
    [global::Microsoft.OData.Client.EntitySet("VestingRules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VestingRule")]
    public partial class VestingRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VestingRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="vestingRule1">Initial value of VestingRule1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VestingRule CreateVestingRule(string dataAreaId, string vestingRule1)
        {
            VestingRule vestingRule = new VestingRule();
            vestingRule.DataAreaId = dataAreaId;
            vestingRule.VestingRule1 = vestingRule1;
            return vestingRule;
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
        /// There are no comments for Property VestingRule1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VestingRule")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VestingRule1 is required.")]
        public virtual string VestingRule1
        {
            get
            {
                return this._VestingRule1;
            }
            set
            {
                this.OnVestingRule1Changing(value);
                this._VestingRule1 = value;
                this.OnVestingRule1Changed();
                this.OnPropertyChanged("VestingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VestingRule1;
        partial void OnVestingRule1Changing(string value);
        partial void OnVestingRule1Changed();
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
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Note")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property CompVarPlanTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompVarPlanTable")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable> CompVarPlanTable
        {
            get
            {
                return this._CompVarPlanTable;
            }
            set
            {
                this.OnCompVarPlanTableChanging(value);
                this._CompVarPlanTable = value;
                this.OnCompVarPlanTableChanged();
                this.OnPropertyChanged("CompVarPlanTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable> _CompVarPlanTable = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompVarPlanTableChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompVarPlanTable> value);
        partial void OnCompVarPlanTableChanged();
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
