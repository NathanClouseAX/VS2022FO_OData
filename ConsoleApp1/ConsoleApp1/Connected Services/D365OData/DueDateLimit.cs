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
    /// There are no comments for DueDateLimitSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DueDateLimitSingle")]
    public partial class DueDateLimitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DueDateLimit>
    {
        /// <summary>
        /// Initialize a new DueDateLimitSingle object.
        /// </summary>
        public DueDateLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DueDateLimitSingle object.
        /// </summary>
        public DueDateLimitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DueDateLimitSingle object.
        /// </summary>
        public DueDateLimitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DueDateLimit> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DueDateLimit in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DueDateLimit
    /// StartDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DueDateLimit", "StartDate")]
    [global::Microsoft.OData.Client.EntitySet("DueDateLimits")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DueDateLimit")]
    public partial class DueDateLimit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DueDateLimit object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="dueDateLimit1">Initial value of DueDateLimit1.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="numberOfUnits">Initial value of NumberOfUnits.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DueDateLimit CreateDueDateLimit(string dataAreaId, string dueDateLimit1, global::System.DateTimeOffset startDate, int numberOfUnits)
        {
            DueDateLimit dueDateLimit = new DueDateLimit();
            dueDateLimit.DataAreaId = dataAreaId;
            dueDateLimit.DueDateLimit1 = dueDateLimit1;
            dueDateLimit.StartDate = startDate;
            dueDateLimit.NumberOfUnits = numberOfUnits;
            return dueDateLimit;
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
        /// There are no comments for Property DueDateLimit1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueDateLimit")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DueDateLimit1 is required.")]
        public virtual string DueDateLimit1
        {
            get
            {
                return this._DueDateLimit1;
            }
            set
            {
                this.OnDueDateLimit1Changing(value);
                this._DueDateLimit1 = value;
                this.OnDueDateLimit1Changed();
                this.OnPropertyChanged("DueDateLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DueDateLimit1;
        partial void OnDueDateLimit1Changing(string value);
        partial void OnDueDateLimit1Changed();
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
        /// There are no comments for Property PeriodInterval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodInterval")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DueDateLimitPeriodUnit_ES> PeriodInterval
        {
            get
            {
                return this._PeriodInterval;
            }
            set
            {
                this.OnPeriodIntervalChanging(value);
                this._PeriodInterval = value;
                this.OnPeriodIntervalChanged();
                this.OnPropertyChanged("PeriodInterval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DueDateLimitPeriodUnit_ES> _PeriodInterval;
        partial void OnPeriodIntervalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DueDateLimitPeriodUnit_ES> value);
        partial void OnPeriodIntervalChanged();
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
        /// There are no comments for Property NumberOfUnits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberOfUnits")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfUnits is required.")]
        public virtual int NumberOfUnits
        {
            get
            {
                return this._NumberOfUnits;
            }
            set
            {
                this.OnNumberOfUnitsChanging(value);
                this._NumberOfUnits = value;
                this.OnNumberOfUnitsChanged();
                this.OnPropertyChanged("NumberOfUnits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfUnits;
        partial void OnNumberOfUnitsChanging(int value);
        partial void OnNumberOfUnitsChanged();
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
