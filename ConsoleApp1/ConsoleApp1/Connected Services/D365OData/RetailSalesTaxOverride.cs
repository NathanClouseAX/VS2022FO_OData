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
    /// There are no comments for RetailSalesTaxOverrideSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailSalesTaxOverrideSingle")]
    public partial class RetailSalesTaxOverrideSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailSalesTaxOverride>
    {
        /// <summary>
        /// Initialize a new RetailSalesTaxOverrideSingle object.
        /// </summary>
        public RetailSalesTaxOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailSalesTaxOverrideSingle object.
        /// </summary>
        public RetailSalesTaxOverrideSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailSalesTaxOverrideSingle object.
        /// </summary>
        public RetailSalesTaxOverrideSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailSalesTaxOverride> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailSalesTaxOverride in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Code")]
    [global::Microsoft.OData.Client.EntitySet("RetailSalesTaxOverrides")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailSalesTaxOverride")]
    public partial class RetailSalesTaxOverride : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailSalesTaxOverride object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailSalesTaxOverride CreateRetailSalesTaxOverride(string dataAreaId, string code)
        {
            RetailSalesTaxOverride retailSalesTaxOverride = new RetailSalesTaxOverride();
            retailSalesTaxOverride.DataAreaId = dataAreaId;
            retailSalesTaxOverride.Code = code;
            return retailSalesTaxOverride;
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
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
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
        /// There are no comments for Property DestinationTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DestinationTaxGroup")]
        public virtual string DestinationTaxGroup
        {
            get
            {
                return this._DestinationTaxGroup;
            }
            set
            {
                this.OnDestinationTaxGroupChanging(value);
                this._DestinationTaxGroup = value;
                this.OnDestinationTaxGroupChanged();
                this.OnPropertyChanged("DestinationTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationTaxGroup;
        partial void OnDestinationTaxGroupChanging(string value);
        partial void OnDestinationTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property SourceTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceTaxGroup")]
        public virtual string SourceTaxGroup
        {
            get
            {
                return this._SourceTaxGroup;
            }
            set
            {
                this.OnSourceTaxGroupChanging(value);
                this._SourceTaxGroup = value;
                this.OnSourceTaxGroupChanged();
                this.OnPropertyChanged("SourceTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceTaxGroup;
        partial void OnSourceTaxGroupChanging(string value);
        partial void OnSourceTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property OverrideType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OverrideType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTaxOverrideType> OverrideType
        {
            get
            {
                return this._OverrideType;
            }
            set
            {
                this.OnOverrideTypeChanging(value);
                this._OverrideType = value;
                this.OnOverrideTypeChanged();
                this.OnPropertyChanged("OverrideType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTaxOverrideType> _OverrideType;
        partial void OnOverrideTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTaxOverrideType> value);
        partial void OnOverrideTypeChanged();
        /// <summary>
        /// There are no comments for Property OverrideFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OverrideFrom")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailOverrideFrom> OverrideFrom
        {
            get
            {
                return this._OverrideFrom;
            }
            set
            {
                this.OnOverrideFromChanging(value);
                this._OverrideFrom = value;
                this.OnOverrideFromChanged();
                this.OnPropertyChanged("OverrideFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailOverrideFrom> _OverrideFrom;
        partial void OnOverrideFromChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailOverrideFrom> value);
        partial void OnOverrideFromChanged();
        /// <summary>
        /// There are no comments for Property OverrideBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OverrideBy")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTaxOverrideBy> OverrideBy
        {
            get
            {
                return this._OverrideBy;
            }
            set
            {
                this.OnOverrideByChanging(value);
                this._OverrideBy = value;
                this.OnOverrideByChanged();
                this.OnPropertyChanged("OverrideBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTaxOverrideBy> _OverrideBy;
        partial void OnOverrideByChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTaxOverrideBy> value);
        partial void OnOverrideByChanged();
        /// <summary>
        /// There are no comments for Property OverrideTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OverrideTo")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailOverrideTo> OverrideTo
        {
            get
            {
                return this._OverrideTo;
            }
            set
            {
                this.OnOverrideToChanging(value);
                this._OverrideTo = value;
                this.OnOverrideToChanged();
                this.OnPropertyChanged("OverrideTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailOverrideTo> _OverrideTo;
        partial void OnOverrideToChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailOverrideTo> value);
        partial void OnOverrideToChanged();
        /// <summary>
        /// There are no comments for Property AdditionalDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalDescription")]
        public virtual string AdditionalDescription
        {
            get
            {
                return this._AdditionalDescription;
            }
            set
            {
                this.OnAdditionalDescriptionChanging(value);
                this._AdditionalDescription = value;
                this.OnAdditionalDescriptionChanged();
                this.OnPropertyChanged("AdditionalDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdditionalDescription;
        partial void OnAdditionalDescriptionChanging(string value);
        partial void OnAdditionalDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EnableDisable> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EnableDisable> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EnableDisable> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property SourceItemTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceItemTaxGroup")]
        public virtual string SourceItemTaxGroup
        {
            get
            {
                return this._SourceItemTaxGroup;
            }
            set
            {
                this.OnSourceItemTaxGroupChanging(value);
                this._SourceItemTaxGroup = value;
                this.OnSourceItemTaxGroupChanged();
                this.OnPropertyChanged("SourceItemTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceItemTaxGroup;
        partial void OnSourceItemTaxGroupChanging(string value);
        partial void OnSourceItemTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property DestinationItemTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DestinationItemTaxGroup")]
        public virtual string DestinationItemTaxGroup
        {
            get
            {
                return this._DestinationItemTaxGroup;
            }
            set
            {
                this.OnDestinationItemTaxGroupChanging(value);
                this._DestinationItemTaxGroup = value;
                this.OnDestinationItemTaxGroupChanged();
                this.OnPropertyChanged("DestinationItemTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DestinationItemTaxGroup;
        partial void OnDestinationItemTaxGroupChanging(string value);
        partial void OnDestinationItemTaxGroupChanged();
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