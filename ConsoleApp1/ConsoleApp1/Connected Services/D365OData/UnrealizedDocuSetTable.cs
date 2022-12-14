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
    /// There are no comments for UnrealizedDocuSetTableSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UnrealizedDocuSetTableSingle")]
    public partial class UnrealizedDocuSetTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UnrealizedDocuSetTable>
    {
        /// <summary>
        /// Initialize a new UnrealizedDocuSetTableSingle object.
        /// </summary>
        public UnrealizedDocuSetTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UnrealizedDocuSetTableSingle object.
        /// </summary>
        public UnrealizedDocuSetTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UnrealizedDocuSetTableSingle object.
        /// </summary>
        public UnrealizedDocuSetTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UnrealizedDocuSetTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for UnrealizedDocuSetTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Code
    /// LineId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Code", "LineId")]
    [global::Microsoft.OData.Client.EntitySet("UnrealizedDocuSetTables")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UnrealizedDocuSetTable")]
    public partial class UnrealizedDocuSetTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UnrealizedDocuSetTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="code">Initial value of Code.</param>
        /// <param name="lineId">Initial value of LineId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UnrealizedDocuSetTable CreateUnrealizedDocuSetTable(string dataAreaId, string code, global::System.Guid lineId)
        {
            UnrealizedDocuSetTable unrealizedDocuSetTable = new UnrealizedDocuSetTable();
            unrealizedDocuSetTable.DataAreaId = dataAreaId;
            unrealizedDocuSetTable.Code = code;
            unrealizedDocuSetTable.LineId = lineId;
            return unrealizedDocuSetTable;
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
        /// There are no comments for Property LineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineId is required.")]
        public virtual global::System.Guid LineId
        {
            get
            {
                return this._LineId;
            }
            set
            {
                this.OnLineIdChanging(value);
                this._LineId = value;
                this.OnLineIdChanged();
                this.OnPropertyChanged("LineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _LineId;
        partial void OnLineIdChanging(global::System.Guid value);
        partial void OnLineIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxUnrealizedDocuPrintLocation> Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxUnrealizedDocuPrintLocation> _Location;
        partial void OnLocationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxUnrealizedDocuPrintLocation> value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property PrintHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrintHeader")]
        public virtual string PrintHeader
        {
            get
            {
                return this._PrintHeader;
            }
            set
            {
                this.OnPrintHeaderChanging(value);
                this._PrintHeader = value;
                this.OnPrintHeaderChanged();
                this.OnPropertyChanged("PrintHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrintHeader;
        partial void OnPrintHeaderChanging(string value);
        partial void OnPrintHeaderChanged();
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
        /// There are no comments for Property ProdType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProdType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxUnrealizedDocuProdType> ProdType
        {
            get
            {
                return this._ProdType;
            }
            set
            {
                this.OnProdTypeChanging(value);
                this._ProdType = value;
                this.OnProdTypeChanged();
                this.OnPropertyChanged("ProdType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxUnrealizedDocuProdType> _ProdType;
        partial void OnProdTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxUnrealizedDocuProdType> value);
        partial void OnProdTypeChanged();
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
