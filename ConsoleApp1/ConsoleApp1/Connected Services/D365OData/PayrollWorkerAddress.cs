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
    /// There are no comments for PayrollWorkerAddressSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollWorkerAddressSingle")]
    public partial class PayrollWorkerAddressSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollWorkerAddress>
    {
        /// <summary>
        /// Initialize a new PayrollWorkerAddressSingle object.
        /// </summary>
        public PayrollWorkerAddressSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollWorkerAddressSingle object.
        /// </summary>
        public PayrollWorkerAddressSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollWorkerAddressSingle object.
        /// </summary>
        public PayrollWorkerAddressSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollWorkerAddress> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PayrollEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollEmployee")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollEmployeeSingle PayrollEmployee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayrollEmployee == null))
                {
                    this._PayrollEmployee = new global::Microsoft.Dynamics.DataEntities.PayrollEmployeeSingle(this.Context, GetPath("PayrollEmployee"));
                }
                return this._PayrollEmployee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollEmployeeSingle _PayrollEmployee;
        /// <summary>
        /// There are no comments for BaseWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseWorker")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle BaseWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BaseWorker == null))
                {
                    this._BaseWorker = new global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle(this.Context, GetPath("BaseWorker"));
                }
                return this._BaseWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorkerSingle _BaseWorker;
    }
    /// <summary>
    /// There are no comments for PayrollWorkerAddress in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// LocationId
    /// PostalAddressValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "LocationId", "PostalAddressValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("PayrollWorkerAddresses")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollWorkerAddress")]
    public partial class PayrollWorkerAddress : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollWorkerAddress object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="locationId">Initial value of LocationId.</param>
        /// <param name="postalAddressValidFrom">Initial value of PostalAddressValidFrom.</param>
        /// <param name="postalAddressValidTo">Initial value of PostalAddressValidTo.</param>
        /// <param name="assignmentDate">Initial value of AssignmentDate.</param>
        /// <param name="payrollEmployee">Initial value of PayrollEmployee.</param>
        /// <param name="baseWorker">Initial value of BaseWorker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollWorkerAddress CreatePayrollWorkerAddress(string personnelNumber, 
                    string locationId, 
                    global::System.DateTimeOffset postalAddressValidFrom, 
                    global::System.DateTimeOffset postalAddressValidTo, 
                    global::System.DateTimeOffset assignmentDate, 
                    global::Microsoft.Dynamics.DataEntities.PayrollEmployee payrollEmployee, 
                    global::Microsoft.Dynamics.DataEntities.BaseWorker baseWorker)
        {
            PayrollWorkerAddress payrollWorkerAddress = new PayrollWorkerAddress();
            payrollWorkerAddress.PersonnelNumber = personnelNumber;
            payrollWorkerAddress.LocationId = locationId;
            payrollWorkerAddress.PostalAddressValidFrom = postalAddressValidFrom;
            payrollWorkerAddress.PostalAddressValidTo = postalAddressValidTo;
            payrollWorkerAddress.AssignmentDate = assignmentDate;
            if ((payrollEmployee == null))
            {
                throw new global::System.ArgumentNullException("payrollEmployee");
            }
            payrollWorkerAddress.PayrollEmployee = payrollEmployee;
            if ((baseWorker == null))
            {
                throw new global::System.ArgumentNullException("baseWorker");
            }
            payrollWorkerAddress.BaseWorker = baseWorker;
            return payrollWorkerAddress;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelNumber is required.")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LocationId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LocationId is required.")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property PostalAddressValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostalAddressValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostalAddressValidFrom is required.")]
        public virtual global::System.DateTimeOffset PostalAddressValidFrom
        {
            get
            {
                return this._PostalAddressValidFrom;
            }
            set
            {
                this.OnPostalAddressValidFromChanging(value);
                this._PostalAddressValidFrom = value;
                this.OnPostalAddressValidFromChanged();
                this.OnPropertyChanged("PostalAddressValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PostalAddressValidFrom;
        partial void OnPostalAddressValidFromChanging(global::System.DateTimeOffset value);
        partial void OnPostalAddressValidFromChanged();
        /// <summary>
        /// There are no comments for Property PostalAddressValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostalAddressValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostalAddressValidTo is required.")]
        public virtual global::System.DateTimeOffset PostalAddressValidTo
        {
            get
            {
                return this._PostalAddressValidTo;
            }
            set
            {
                this.OnPostalAddressValidToChanging(value);
                this._PostalAddressValidTo = value;
                this.OnPostalAddressValidToChanged();
                this.OnPropertyChanged("PostalAddressValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PostalAddressValidTo;
        partial void OnPostalAddressValidToChanging(global::System.DateTimeOffset value);
        partial void OnPostalAddressValidToChanged();
        /// <summary>
        /// There are no comments for Property ZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ZipCode")]
        public virtual string ZipCode
        {
            get
            {
                return this._ZipCode;
            }
            set
            {
                this.OnZipCodeChanging(value);
                this._ZipCode = value;
                this.OnZipCodeChanged();
                this.OnPropertyChanged("ZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZipCode;
        partial void OnZipCodeChanging(string value);
        partial void OnZipCodeChanged();
        /// <summary>
        /// There are no comments for Property AssignmentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignmentDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AssignmentDate is required.")]
        public virtual global::System.DateTimeOffset AssignmentDate
        {
            get
            {
                return this._AssignmentDate;
            }
            set
            {
                this.OnAssignmentDateChanging(value);
                this._AssignmentDate = value;
                this.OnAssignmentDateChanged();
                this.OnPropertyChanged("AssignmentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _AssignmentDate;
        partial void OnAssignmentDateChanging(global::System.DateTimeOffset value);
        partial void OnAssignmentDateChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryRegionId")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property County in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("County")]
        public virtual string County
        {
            get
            {
                return this._County;
            }
            set
            {
                this.OnCountyChanging(value);
                this._County = value;
                this.OnCountyChanged();
                this.OnPropertyChanged("County");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _County;
        partial void OnCountyChanging(string value);
        partial void OnCountyChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("City")]
        public virtual string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property IsLivedInAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsLivedInAddress")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsLivedInAddress
        {
            get
            {
                return this._IsLivedInAddress;
            }
            set
            {
                this.OnIsLivedInAddressChanging(value);
                this._IsLivedInAddress = value;
                this.OnIsLivedInAddressChanged();
                this.OnPropertyChanged("IsLivedInAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsLivedInAddress;
        partial void OnIsLivedInAddressChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsLivedInAddressChanged();
        /// <summary>
        /// There are no comments for Property Street in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Street")]
        public virtual string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                this.OnStreetChanging(value);
                this._Street = value;
                this.OnStreetChanged();
                this.OnPropertyChanged("Street");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Street;
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        /// <summary>
        /// There are no comments for Property IsWorkedInAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsWorkedInAddress")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsWorkedInAddress
        {
            get
            {
                return this._IsWorkedInAddress;
            }
            set
            {
                this.OnIsWorkedInAddressChanging(value);
                this._IsWorkedInAddress = value;
                this.OnIsWorkedInAddressChanged();
                this.OnPropertyChanged("IsWorkedInAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsWorkedInAddress;
        partial void OnIsWorkedInAddressChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsWorkedInAddressChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property PayrollEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollEmployee")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PayrollEmployee is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayrollEmployee PayrollEmployee
        {
            get
            {
                return this._PayrollEmployee;
            }
            set
            {
                this.OnPayrollEmployeeChanging(value);
                this._PayrollEmployee = value;
                this.OnPayrollEmployeeChanged();
                this.OnPropertyChanged("PayrollEmployee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayrollEmployee _PayrollEmployee;
        partial void OnPayrollEmployeeChanging(global::Microsoft.Dynamics.DataEntities.PayrollEmployee value);
        partial void OnPayrollEmployeeChanged();
        /// <summary>
        /// There are no comments for Property BaseWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseWorker")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BaseWorker is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.BaseWorker BaseWorker
        {
            get
            {
                return this._BaseWorker;
            }
            set
            {
                this.OnBaseWorkerChanging(value);
                this._BaseWorker = value;
                this.OnBaseWorkerChanged();
                this.OnPropertyChanged("BaseWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BaseWorker _BaseWorker;
        partial void OnBaseWorkerChanging(global::Microsoft.Dynamics.DataEntities.BaseWorker value);
        partial void OnBaseWorkerChanged();
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
