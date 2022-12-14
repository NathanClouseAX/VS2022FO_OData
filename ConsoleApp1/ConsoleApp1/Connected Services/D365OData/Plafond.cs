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
    /// There are no comments for PlafondSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PlafondSingle")]
    public partial class PlafondSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Plafond>
    {
        /// <summary>
        /// Initialize a new PlafondSingle object.
        /// </summary>
        public PlafondSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PlafondSingle object.
        /// </summary>
        public PlafondSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PlafondSingle object.
        /// </summary>
        public PlafondSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Plafond> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Plafond in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PlafondId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PlafondId")]
    [global::Microsoft.OData.Client.EntitySet("Plafonds")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Plafond")]
    public partial class Plafond : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Plafond object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="plafondId">Initial value of PlafondId.</param>
        /// <param name="currentAmount">Initial value of CurrentAmount.</param>
        /// <param name="limitPercent">Initial value of LimitPercent.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        /// <param name="limitAmount">Initial value of LimitAmount.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="initialAmount">Initial value of InitialAmount.</param>
        /// <param name="closedDate">Initial value of ClosedDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Plafond CreatePlafond(string dataAreaId, 
                    string plafondId, 
                    decimal currentAmount, 
                    decimal limitPercent, 
                    global::System.DateTimeOffset toDate, 
                    decimal limitAmount, 
                    global::System.DateTimeOffset fromDate, 
                    decimal initialAmount, 
                    global::System.DateTimeOffset closedDate)
        {
            Plafond plafond = new Plafond();
            plafond.DataAreaId = dataAreaId;
            plafond.PlafondId = plafondId;
            plafond.CurrentAmount = currentAmount;
            plafond.LimitPercent = limitPercent;
            plafond.ToDate = toDate;
            plafond.LimitAmount = limitAmount;
            plafond.FromDate = fromDate;
            plafond.InitialAmount = initialAmount;
            plafond.ClosedDate = closedDate;
            return plafond;
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
        /// There are no comments for Property PlafondId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlafondId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PlafondId is required.")]
        public virtual string PlafondId
        {
            get
            {
                return this._PlafondId;
            }
            set
            {
                this.OnPlafondIdChanging(value);
                this._PlafondId = value;
                this.OnPlafondIdChanged();
                this.OnPropertyChanged("PlafondId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PlafondId;
        partial void OnPlafondIdChanging(string value);
        partial void OnPlafondIdChanged();
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
        /// There are no comments for Property CurrentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrentAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CurrentAmount is required.")]
        public virtual decimal CurrentAmount
        {
            get
            {
                return this._CurrentAmount;
            }
            set
            {
                this.OnCurrentAmountChanging(value);
                this._CurrentAmount = value;
                this.OnCurrentAmountChanged();
                this.OnPropertyChanged("CurrentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CurrentAmount;
        partial void OnCurrentAmountChanging(decimal value);
        partial void OnCurrentAmountChanged();
        /// <summary>
        /// There are no comments for Property LimitPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LimitPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LimitPercent is required.")]
        public virtual decimal LimitPercent
        {
            get
            {
                return this._LimitPercent;
            }
            set
            {
                this.OnLimitPercentChanging(value);
                this._LimitPercent = value;
                this.OnLimitPercentChanged();
                this.OnPropertyChanged("LimitPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LimitPercent;
        partial void OnLimitPercentChanging(decimal value);
        partial void OnLimitPercentChanged();
        /// <summary>
        /// There are no comments for Property ToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ToDate is required.")]
        public virtual global::System.DateTimeOffset ToDate
        {
            get
            {
                return this._ToDate;
            }
            set
            {
                this.OnToDateChanging(value);
                this._ToDate = value;
                this.OnToDateChanged();
                this.OnPropertyChanged("ToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDate;
        partial void OnToDateChanging(global::System.DateTimeOffset value);
        partial void OnToDateChanged();
        /// <summary>
        /// There are no comments for Property Exportation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Exportation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Exportation
        {
            get
            {
                return this._Exportation;
            }
            set
            {
                this.OnExportationChanging(value);
                this._Exportation = value;
                this.OnExportationChanged();
                this.OnPropertyChanged("Exportation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Exportation;
        partial void OnExportationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnExportationChanged();
        /// <summary>
        /// There are no comments for Property LimitAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LimitAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LimitAmount is required.")]
        public virtual decimal LimitAmount
        {
            get
            {
                return this._LimitAmount;
            }
            set
            {
                this.OnLimitAmountChanging(value);
                this._LimitAmount = value;
                this.OnLimitAmountChanged();
                this.OnPropertyChanged("LimitAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LimitAmount;
        partial void OnLimitAmountChanging(decimal value);
        partial void OnLimitAmountChanged();
        /// <summary>
        /// There are no comments for Property SpecialOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SpecialOperations")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SpecialOperations
        {
            get
            {
                return this._SpecialOperations;
            }
            set
            {
                this.OnSpecialOperationsChanging(value);
                this._SpecialOperations = value;
                this.OnSpecialOperationsChanged();
                this.OnPropertyChanged("SpecialOperations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SpecialOperations;
        partial void OnSpecialOperationsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSpecialOperationsChanged();
        /// <summary>
        /// There are no comments for Property NoLimitCheck in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NoLimitCheck")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> NoLimitCheck
        {
            get
            {
                return this._NoLimitCheck;
            }
            set
            {
                this.OnNoLimitCheckChanging(value);
                this._NoLimitCheck = value;
                this.OnNoLimitCheckChanged();
                this.OnPropertyChanged("NoLimitCheck");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _NoLimitCheck;
        partial void OnNoLimitCheckChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnNoLimitCheckChanged();
        /// <summary>
        /// There are no comments for Property PlafondType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlafondType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondType_IT> PlafondType
        {
            get
            {
                return this._PlafondType;
            }
            set
            {
                this.OnPlafondTypeChanging(value);
                this._PlafondType = value;
                this.OnPlafondTypeChanged();
                this.OnPropertyChanged("PlafondType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondType_IT> _PlafondType;
        partial void OnPlafondTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondType_IT> value);
        partial void OnPlafondTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxPeriod")]
        public virtual string TaxPeriod
        {
            get
            {
                return this._TaxPeriod;
            }
            set
            {
                this.OnTaxPeriodChanging(value);
                this._TaxPeriod = value;
                this.OnTaxPeriodChanged();
                this.OnPropertyChanged("TaxPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxPeriod;
        partial void OnTaxPeriodChanging(string value);
        partial void OnTaxPeriodChanged();
        /// <summary>
        /// There are no comments for Property SanMarinoSales in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SanMarinoSales")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SanMarinoSales
        {
            get
            {
                return this._SanMarinoSales;
            }
            set
            {
                this.OnSanMarinoSalesChanging(value);
                this._SanMarinoSales = value;
                this.OnSanMarinoSalesChanged();
                this.OnPropertyChanged("SanMarinoSales");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SanMarinoSales;
        partial void OnSanMarinoSalesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSanMarinoSalesChanged();
        /// <summary>
        /// There are no comments for Property LimitType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LimitType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondLimitType_IT> LimitType
        {
            get
            {
                return this._LimitType;
            }
            set
            {
                this.OnLimitTypeChanging(value);
                this._LimitType = value;
                this.OnLimitTypeChanged();
                this.OnPropertyChanged("LimitType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondLimitType_IT> _LimitType;
        partial void OnLimitTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondLimitType_IT> value);
        partial void OnLimitTypeChanged();
        /// <summary>
        /// There are no comments for Property EUSales in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EUSales")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EUSales
        {
            get
            {
                return this._EUSales;
            }
            set
            {
                this.OnEUSalesChanging(value);
                this._EUSales = value;
                this.OnEUSalesChanged();
                this.OnPropertyChanged("EUSales");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EUSales;
        partial void OnEUSalesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEUSalesChanged();
        /// <summary>
        /// There are no comments for Property FromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FromDate is required.")]
        public virtual global::System.DateTimeOffset FromDate
        {
            get
            {
                return this._FromDate;
            }
            set
            {
                this.OnFromDateChanging(value);
                this._FromDate = value;
                this.OnFromDateChanged();
                this.OnPropertyChanged("FromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDate;
        partial void OnFromDateChanging(global::System.DateTimeOffset value);
        partial void OnFromDateChanged();
        /// <summary>
        /// There are no comments for Property InitialAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InitialAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InitialAmount is required.")]
        public virtual decimal InitialAmount
        {
            get
            {
                return this._InitialAmount;
            }
            set
            {
                this.OnInitialAmountChanging(value);
                this._InitialAmount = value;
                this.OnInitialAmountChanged();
                this.OnPropertyChanged("InitialAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InitialAmount;
        partial void OnInitialAmountChanging(decimal value);
        partial void OnInitialAmountChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondStatus_IT> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondStatus_IT> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PlafondStatus_IT> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ClosedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClosedDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ClosedDate is required.")]
        public virtual global::System.DateTimeOffset ClosedDate
        {
            get
            {
                return this._ClosedDate;
            }
            set
            {
                this.OnClosedDateChanging(value);
                this._ClosedDate = value;
                this.OnClosedDateChanged();
                this.OnPropertyChanged("ClosedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ClosedDate;
        partial void OnClosedDateChanging(global::System.DateTimeOffset value);
        partial void OnClosedDateChanged();
        /// <summary>
        /// There are no comments for Property AssimilatedOperations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssimilatedOperations")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AssimilatedOperations
        {
            get
            {
                return this._AssimilatedOperations;
            }
            set
            {
                this.OnAssimilatedOperationsChanging(value);
                this._AssimilatedOperations = value;
                this.OnAssimilatedOperationsChanged();
                this.OnPropertyChanged("AssimilatedOperations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AssimilatedOperations;
        partial void OnAssimilatedOperationsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAssimilatedOperationsChanged();
        /// <summary>
        /// There are no comments for Property VATDeclarationPresented in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATDeclarationPresented")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> VATDeclarationPresented
        {
            get
            {
                return this._VATDeclarationPresented;
            }
            set
            {
                this.OnVATDeclarationPresentedChanging(value);
                this._VATDeclarationPresented = value;
                this.OnVATDeclarationPresentedChanged();
                this.OnPropertyChanged("VATDeclarationPresented");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _VATDeclarationPresented;
        partial void OnVATDeclarationPresentedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnVATDeclarationPresentedChanged();
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
