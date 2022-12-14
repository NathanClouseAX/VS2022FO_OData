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
    /// There are no comments for DepreciationGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationGroupSingle")]
    public partial class DepreciationGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DepreciationGroup>
    {
        /// <summary>
        /// Initialize a new DepreciationGroupSingle object.
        /// </summary>
        public DepreciationGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DepreciationGroupSingle object.
        /// </summary>
        public DepreciationGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DepreciationGroupSingle object.
        /// </summary>
        public DepreciationGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DepreciationGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DepreciationGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DepreciationGroup
    /// StartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DepreciationGroup", "StartDate")]
    [global::Microsoft.OData.Client.EntitySet("DepreciationGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationGroup")]
    public partial class DepreciationGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DepreciationGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="depreciationGroup1">Initial value of DepreciationGroup1.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="factorAlt">Initial value of FactorAlt.</param>
        /// <param name="factorExt">Initial value of FactorExt.</param>
        /// <param name="factor">Initial value of Factor.</param>
        /// <param name="costLimit_PL">Initial value of CostLimit_PL.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DepreciationGroup CreateDepreciationGroup(string dataAreaId, 
                    string depreciationGroup1, 
                    global::System.DateTimeOffset startDate, 
                    decimal factorAlt, 
                    decimal factorExt, 
                    decimal factor, 
                    decimal costLimit_PL)
        {
            DepreciationGroup depreciationGroup = new DepreciationGroup();
            depreciationGroup.DataAreaId = dataAreaId;
            depreciationGroup.DepreciationGroup1 = depreciationGroup1;
            depreciationGroup.StartDate = startDate;
            depreciationGroup.FactorAlt = factorAlt;
            depreciationGroup.FactorExt = factorExt;
            depreciationGroup.Factor = factor;
            depreciationGroup.CostLimit_PL = costLimit_PL;
            return depreciationGroup;
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
        /// There are no comments for Property DepreciationGroup1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DepreciationGroup1 is required.")]
        public virtual string DepreciationGroup1
        {
            get
            {
                return this._DepreciationGroup1;
            }
            set
            {
                this.OnDepreciationGroup1Changing(value);
                this._DepreciationGroup1 = value;
                this.OnDepreciationGroup1Changed();
                this.OnPropertyChanged("DepreciationGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationGroup1;
        partial void OnDepreciationGroup1Changing(string value);
        partial void OnDepreciationGroup1Changed();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property FactorAlt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FactorAlt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FactorAlt is required.")]
        public virtual decimal FactorAlt
        {
            get
            {
                return this._FactorAlt;
            }
            set
            {
                this.OnFactorAltChanging(value);
                this._FactorAlt = value;
                this.OnFactorAltChanged();
                this.OnPropertyChanged("FactorAlt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FactorAlt;
        partial void OnFactorAltChanging(decimal value);
        partial void OnFactorAltChanged();
        /// <summary>
        /// There are no comments for Property FactorExt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FactorExt")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FactorExt is required.")]
        public virtual decimal FactorExt
        {
            get
            {
                return this._FactorExt;
            }
            set
            {
                this.OnFactorExtChanging(value);
                this._FactorExt = value;
                this.OnFactorExtChanged();
                this.OnPropertyChanged("FactorExt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FactorExt;
        partial void OnFactorExtChanging(decimal value);
        partial void OnFactorExtChanged();
        /// <summary>
        /// There are no comments for Property Factor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Factor is required.")]
        public virtual decimal Factor
        {
            get
            {
                return this._Factor;
            }
            set
            {
                this.OnFactorChanging(value);
                this._Factor = value;
                this.OnFactorChanged();
                this.OnPropertyChanged("Factor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Factor;
        partial void OnFactorChanging(decimal value);
        partial void OnFactorChanged();
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
        /// There are no comments for Property CostLimit_PL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CostLimit_PL")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CostLimit_PL is required.")]
        public virtual decimal CostLimit_PL
        {
            get
            {
                return this._CostLimit_PL;
            }
            set
            {
                this.OnCostLimit_PLChanging(value);
                this._CostLimit_PL = value;
                this.OnCostLimit_PLChanged();
                this.OnPropertyChanged("CostLimit_PL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CostLimit_PL;
        partial void OnCostLimit_PLChanging(decimal value);
        partial void OnCostLimit_PLChanged();
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
