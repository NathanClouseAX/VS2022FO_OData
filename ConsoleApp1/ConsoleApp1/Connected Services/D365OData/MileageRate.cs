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
    /// There are no comments for MileageRateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MileageRateSingle")]
    public partial class MileageRateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MileageRate>
    {
        /// <summary>
        /// Initialize a new MileageRateSingle object.
        /// </summary>
        public MileageRateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MileageRateSingle object.
        /// </summary>
        public MileageRateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MileageRateSingle object.
        /// </summary>
        public MileageRateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MileageRate> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MileageRate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ExpenseCategory
    /// FromDate
    /// Quantity
    /// RateType
    /// VehicleType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ExpenseCategory", "FromDate", "Quantity", "RateType", "VehicleType")]
    [global::Microsoft.OData.Client.EntitySet("MileageRates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MileageRate")]
    public partial class MileageRate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MileageRate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="expenseCategory">Initial value of ExpenseCategory.</param>
        /// <param name="fromDate">Initial value of FromDate.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="vehicleType">Initial value of VehicleType.</param>
        /// <param name="rate">Initial value of Rate.</param>
        /// <param name="toDate">Initial value of ToDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MileageRate CreateMileageRate(string dataAreaId, 
                    string expenseCategory, 
                    global::System.DateTimeOffset fromDate, 
                    decimal quantity, 
                    string vehicleType, 
                    decimal rate, 
                    global::System.DateTimeOffset toDate)
        {
            MileageRate mileageRate = new MileageRate();
            mileageRate.DataAreaId = dataAreaId;
            mileageRate.ExpenseCategory = expenseCategory;
            mileageRate.FromDate = fromDate;
            mileageRate.Quantity = quantity;
            mileageRate.VehicleType = vehicleType;
            mileageRate.Rate = rate;
            mileageRate.ToDate = toDate;
            return mileageRate;
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
        /// There are no comments for Property ExpenseCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseCategory")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExpenseCategory is required.")]
        public virtual string ExpenseCategory
        {
            get
            {
                return this._ExpenseCategory;
            }
            set
            {
                this.OnExpenseCategoryChanging(value);
                this._ExpenseCategory = value;
                this.OnExpenseCategoryChanged();
                this.OnPropertyChanged("ExpenseCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExpenseCategory;
        partial void OnExpenseCategoryChanging(string value);
        partial void OnExpenseCategoryChanged();
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
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property RateType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RateType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvMileageRateType> RateType
        {
            get
            {
                return this._RateType;
            }
            set
            {
                this.OnRateTypeChanging(value);
                this._RateType = value;
                this.OnRateTypeChanged();
                this.OnPropertyChanged("RateType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvMileageRateType> _RateType;
        partial void OnRateTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvMileageRateType> value);
        partial void OnRateTypeChanged();
        /// <summary>
        /// There are no comments for Property VehicleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VehicleType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VehicleType is required.")]
        public virtual string VehicleType
        {
            get
            {
                return this._VehicleType;
            }
            set
            {
                this.OnVehicleTypeChanging(value);
                this._VehicleType = value;
                this.OnVehicleTypeChanged();
                this.OnPropertyChanged("VehicleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VehicleType;
        partial void OnVehicleTypeChanging(string value);
        partial void OnVehicleTypeChanged();
        /// <summary>
        /// There are no comments for Property Rate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Rate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Rate is required.")]
        public virtual decimal Rate
        {
            get
            {
                return this._Rate;
            }
            set
            {
                this.OnRateChanging(value);
                this._Rate = value;
                this.OnRateChanged();
                this.OnPropertyChanged("Rate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Rate;
        partial void OnRateChanging(decimal value);
        partial void OnRateChanged();
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