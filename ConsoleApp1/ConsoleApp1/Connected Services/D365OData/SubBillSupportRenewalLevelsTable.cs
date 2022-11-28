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
    /// There are no comments for SubBillSupportRenewalLevelsTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillSupportRenewalLevelsTableSingle")]
    public partial class SubBillSupportRenewalLevelsTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillSupportRenewalLevelsTable>
    {
        /// <summary>
        /// Initialize a new SubBillSupportRenewalLevelsTableSingle object.
        /// </summary>
        public SubBillSupportRenewalLevelsTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillSupportRenewalLevelsTableSingle object.
        /// </summary>
        public SubBillSupportRenewalLevelsTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillSupportRenewalLevelsTableSingle object.
        /// </summary>
        public SubBillSupportRenewalLevelsTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillSupportRenewalLevelsTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SubBillSupportRenewalLevelsTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SupportLevel
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SupportLevel")]
    [global::Microsoft.OData.Client.EntitySet("SubBillSupportRenewalLevelsTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillSupportRenewalLevelsTable")]
    public partial class SubBillSupportRenewalLevelsTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillSupportRenewalLevelsTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="supportLevel">Initial value of SupportLevel.</param>
        /// <param name="renewalPercentage">Initial value of RenewalPercentage.</param>
        /// <param name="supportPercentage">Initial value of SupportPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillSupportRenewalLevelsTable CreateSubBillSupportRenewalLevelsTable(string dataAreaId, string supportLevel, decimal renewalPercentage, decimal supportPercentage)
        {
            SubBillSupportRenewalLevelsTable subBillSupportRenewalLevelsTable = new SubBillSupportRenewalLevelsTable();
            subBillSupportRenewalLevelsTable.DataAreaId = dataAreaId;
            subBillSupportRenewalLevelsTable.SupportLevel = supportLevel;
            subBillSupportRenewalLevelsTable.RenewalPercentage = renewalPercentage;
            subBillSupportRenewalLevelsTable.SupportPercentage = supportPercentage;
            return subBillSupportRenewalLevelsTable;
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
        /// There are no comments for Property SupportLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SupportLevel")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SupportLevel is required.")]
        public virtual string SupportLevel
        {
            get
            {
                return this._SupportLevel;
            }
            set
            {
                this.OnSupportLevelChanging(value);
                this._SupportLevel = value;
                this.OnSupportLevelChanged();
                this.OnPropertyChanged("SupportLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SupportLevel;
        partial void OnSupportLevelChanging(string value);
        partial void OnSupportLevelChanged();
        /// <summary>
        /// There are no comments for Property RenewalPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RenewalPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RenewalPercentage is required.")]
        public virtual decimal RenewalPercentage
        {
            get
            {
                return this._RenewalPercentage;
            }
            set
            {
                this.OnRenewalPercentageChanging(value);
                this._RenewalPercentage = value;
                this.OnRenewalPercentageChanged();
                this.OnPropertyChanged("RenewalPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RenewalPercentage;
        partial void OnRenewalPercentageChanging(decimal value);
        partial void OnRenewalPercentageChanged();
        /// <summary>
        /// There are no comments for Property RenewalCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RenewalCalculationMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillRenewalCalculationMethod> RenewalCalculationMethod
        {
            get
            {
                return this._RenewalCalculationMethod;
            }
            set
            {
                this.OnRenewalCalculationMethodChanging(value);
                this._RenewalCalculationMethod = value;
                this.OnRenewalCalculationMethodChanged();
                this.OnPropertyChanged("RenewalCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillRenewalCalculationMethod> _RenewalCalculationMethod;
        partial void OnRenewalCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillRenewalCalculationMethod> value);
        partial void OnRenewalCalculationMethodChanged();
        /// <summary>
        /// There are no comments for Property SupportPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SupportPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SupportPercentage is required.")]
        public virtual decimal SupportPercentage
        {
            get
            {
                return this._SupportPercentage;
            }
            set
            {
                this.OnSupportPercentageChanging(value);
                this._SupportPercentage = value;
                this.OnSupportPercentageChanged();
                this.OnPropertyChanged("SupportPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SupportPercentage;
        partial void OnSupportPercentageChanging(decimal value);
        partial void OnSupportPercentageChanged();
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
        /// There are no comments for Property SupportCalculationMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SupportCalculationMethod")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillSupportCalculationMethod> SupportCalculationMethod
        {
            get
            {
                return this._SupportCalculationMethod;
            }
            set
            {
                this.OnSupportCalculationMethodChanging(value);
                this._SupportCalculationMethod = value;
                this.OnSupportCalculationMethodChanged();
                this.OnPropertyChanged("SupportCalculationMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillSupportCalculationMethod> _SupportCalculationMethod;
        partial void OnSupportCalculationMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillSupportCalculationMethod> value);
        partial void OnSupportCalculationMethodChanged();
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