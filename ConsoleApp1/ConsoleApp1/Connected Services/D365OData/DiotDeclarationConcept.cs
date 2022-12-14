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
    /// There are no comments for DiotDeclarationConceptSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DiotDeclarationConceptSingle")]
    public partial class DiotDeclarationConceptSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DiotDeclarationConcept>
    {
        /// <summary>
        /// Initialize a new DiotDeclarationConceptSingle object.
        /// </summary>
        public DiotDeclarationConceptSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DiotDeclarationConceptSingle object.
        /// </summary>
        public DiotDeclarationConceptSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DiotDeclarationConceptSingle object.
        /// </summary>
        public DiotDeclarationConceptSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DiotDeclarationConcept> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DiotDeclarationConcept in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ConceptId
    /// TaxCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ConceptId", "TaxCode")]
    [global::Microsoft.OData.Client.EntitySet("DiotDeclarationConcepts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DiotDeclarationConcept")]
    public partial class DiotDeclarationConcept : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DiotDeclarationConcept object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="conceptId">Initial value of ConceptId.</param>
        /// <param name="taxCode">Initial value of TaxCode.</param>
        /// <param name="orderNumber">Initial value of OrderNumber.</param>
        /// <param name="nondeductibleamount">Initial value of Nondeductibleamount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DiotDeclarationConcept CreateDiotDeclarationConcept(string dataAreaId, int conceptId, string taxCode, int orderNumber, decimal nondeductibleamount)
        {
            DiotDeclarationConcept diotDeclarationConcept = new DiotDeclarationConcept();
            diotDeclarationConcept.DataAreaId = dataAreaId;
            diotDeclarationConcept.ConceptId = conceptId;
            diotDeclarationConcept.TaxCode = taxCode;
            diotDeclarationConcept.OrderNumber = orderNumber;
            diotDeclarationConcept.Nondeductibleamount = nondeductibleamount;
            return diotDeclarationConcept;
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
        /// There are no comments for Property ConceptId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConceptId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ConceptId is required.")]
        public virtual int ConceptId
        {
            get
            {
                return this._ConceptId;
            }
            set
            {
                this.OnConceptIdChanging(value);
                this._ConceptId = value;
                this.OnConceptIdChanged();
                this.OnPropertyChanged("ConceptId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ConceptId;
        partial void OnConceptIdChanging(int value);
        partial void OnConceptIdChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxCode is required.")]
        public virtual string TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCode;
        partial void OnTaxCodeChanging(string value);
        partial void OnTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property TaxName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxName")]
        public virtual string TaxName
        {
            get
            {
                return this._TaxName;
            }
            set
            {
                this.OnTaxNameChanging(value);
                this._TaxName = value;
                this.OnTaxNameChanged();
                this.OnPropertyChanged("TaxName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxName;
        partial void OnTaxNameChanging(string value);
        partial void OnTaxNameChanged();
        /// <summary>
        /// There are no comments for Property OrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OrderNumber is required.")]
        public virtual int OrderNumber
        {
            get
            {
                return this._OrderNumber;
            }
            set
            {
                this.OnOrderNumberChanging(value);
                this._OrderNumber = value;
                this.OnOrderNumberChanged();
                this.OnPropertyChanged("OrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OrderNumber;
        partial void OnOrderNumberChanging(int value);
        partial void OnOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property Nondeductibleamount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Nondeductibleamount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Nondeductibleamount is required.")]
        public virtual decimal Nondeductibleamount
        {
            get
            {
                return this._Nondeductibleamount;
            }
            set
            {
                this.OnNondeductibleamountChanging(value);
                this._Nondeductibleamount = value;
                this.OnNondeductibleamountChanged();
                this.OnPropertyChanged("Nondeductibleamount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Nondeductibleamount;
        partial void OnNondeductibleamountChanging(decimal value);
        partial void OnNondeductibleamountChanged();
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
        /// There are no comments for Property ColumnType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DIOTColumnType_MX> ColumnType
        {
            get
            {
                return this._ColumnType;
            }
            set
            {
                this.OnColumnTypeChanging(value);
                this._ColumnType = value;
                this.OnColumnTypeChanged();
                this.OnPropertyChanged("ColumnType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DIOTColumnType_MX> _ColumnType;
        partial void OnColumnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DIOTColumnType_MX> value);
        partial void OnColumnTypeChanged();
        /// <summary>
        /// There are no comments for Property Nondeductible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Nondeductible")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Nondeductible
        {
            get
            {
                return this._Nondeductible;
            }
            set
            {
                this.OnNondeductibleChanging(value);
                this._Nondeductible = value;
                this.OnNondeductibleChanged();
                this.OnPropertyChanged("Nondeductible");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Nondeductible;
        partial void OnNondeductibleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnNondeductibleChanged();
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
