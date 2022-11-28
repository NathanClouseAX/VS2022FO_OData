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
    /// There are no comments for AllocationRuleSourceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationRuleSourceSingle")]
    public partial class AllocationRuleSourceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationRuleSource>
    {
        /// <summary>
        /// Initialize a new AllocationRuleSourceSingle object.
        /// </summary>
        public AllocationRuleSourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AllocationRuleSourceSingle object.
        /// </summary>
        public AllocationRuleSourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AllocationRuleSourceSingle object.
        /// </summary>
        public AllocationRuleSourceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AllocationRuleSource> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AllocationRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationRule")]
        public virtual global::Microsoft.Dynamics.DataEntities.AllocationRuleSingle AllocationRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AllocationRule == null))
                {
                    this._AllocationRule = new global::Microsoft.Dynamics.DataEntities.AllocationRuleSingle(this.Context, GetPath("AllocationRule"));
                }
                return this._AllocationRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AllocationRuleSingle _AllocationRule;
    }
    /// <summary>
    /// There are no comments for AllocationRuleSource in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Rule
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Rule", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("AllocationRuleSources")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationRuleSource")]
    public partial class AllocationRuleSource : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AllocationRuleSource object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="rule">Initial value of Rule.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="allocationRule">Initial value of AllocationRule.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AllocationRuleSource CreateAllocationRuleSource(string dataAreaId, string rule, decimal lineNumber, global::Microsoft.Dynamics.DataEntities.AllocationRule allocationRule)
        {
            AllocationRuleSource allocationRuleSource = new AllocationRuleSource();
            allocationRuleSource.DataAreaId = dataAreaId;
            allocationRuleSource.Rule = rule;
            allocationRuleSource.LineNumber = lineNumber;
            if ((allocationRule == null))
            {
                throw new global::System.ArgumentNullException("allocationRule");
            }
            allocationRuleSource.AllocationRule = allocationRule;
            return allocationRuleSource;
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
        /// There are no comments for Property Rule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Rule")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Rule is required.")]
        public virtual string Rule
        {
            get
            {
                return this._Rule;
            }
            set
            {
                this.OnRuleChanging(value);
                this._Rule = value;
                this.OnRuleChanged();
                this.OnPropertyChanged("Rule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Rule;
        partial void OnRuleChanging(string value);
        partial void OnRuleChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNumber is required.")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property SourceCriteria in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceCriteria")]
        public virtual string SourceCriteria
        {
            get
            {
                return this._SourceCriteria;
            }
            set
            {
                this.OnSourceCriteriaChanging(value);
                this._SourceCriteria = value;
                this.OnSourceCriteriaChanged();
                this.OnPropertyChanged("SourceCriteria");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceCriteria;
        partial void OnSourceCriteriaChanging(string value);
        partial void OnSourceCriteriaChanged();
        /// <summary>
        /// There are no comments for Property DimensionAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionAttributeName")]
        public virtual string DimensionAttributeName
        {
            get
            {
                return this._DimensionAttributeName;
            }
            set
            {
                this.OnDimensionAttributeNameChanging(value);
                this._DimensionAttributeName = value;
                this.OnDimensionAttributeNameChanged();
                this.OnPropertyChanged("DimensionAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionAttributeName;
        partial void OnDimensionAttributeNameChanging(string value);
        partial void OnDimensionAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property FieldSetting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldSetting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationAccountDimension> FieldSetting
        {
            get
            {
                return this._FieldSetting;
            }
            set
            {
                this.OnFieldSettingChanging(value);
                this._FieldSetting = value;
                this.OnFieldSettingChanged();
                this.OnPropertyChanged("FieldSetting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationAccountDimension> _FieldSetting;
        partial void OnFieldSettingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerAllocationAccountDimension> value);
        partial void OnFieldSettingChanged();
        /// <summary>
        /// There are no comments for Property AllocationRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllocationRule")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AllocationRule is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AllocationRule AllocationRule
        {
            get
            {
                return this._AllocationRule;
            }
            set
            {
                this.OnAllocationRuleChanging(value);
                this._AllocationRule = value;
                this.OnAllocationRuleChanged();
                this.OnPropertyChanged("AllocationRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AllocationRule _AllocationRule;
        partial void OnAllocationRuleChanging(global::Microsoft.Dynamics.DataEntities.AllocationRule value);
        partial void OnAllocationRuleChanged();
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
