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
    /// There are no comments for TransportationAppointmentDriverLogSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransportationAppointmentDriverLogSingle")]
    public partial class TransportationAppointmentDriverLogSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TransportationAppointmentDriverLog>
    {
        /// <summary>
        /// Initialize a new TransportationAppointmentDriverLogSingle object.
        /// </summary>
        public TransportationAppointmentDriverLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TransportationAppointmentDriverLogSingle object.
        /// </summary>
        public TransportationAppointmentDriverLogSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TransportationAppointmentDriverLogSingle object.
        /// </summary>
        public TransportationAppointmentDriverLogSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TransportationAppointmentDriverLog> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TransportationAppointmentDriverLog in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// AppointmentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AppointmentId")]
    [global::Microsoft.OData.Client.EntitySet("TransportationAppointmentDriverLogs")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TransportationAppointmentDriverLog")]
    public partial class TransportationAppointmentDriverLog : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TransportationAppointmentDriverLog object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="appointmentId">Initial value of AppointmentId.</param>
        /// <param name="actualAppointmentEndDateTime">Initial value of ActualAppointmentEndDateTime.</param>
        /// <param name="actualAppointmentStartDateTime">Initial value of ActualAppointmentStartDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TransportationAppointmentDriverLog CreateTransportationAppointmentDriverLog(string dataAreaId, string appointmentId, global::System.DateTimeOffset actualAppointmentEndDateTime, global::System.DateTimeOffset actualAppointmentStartDateTime)
        {
            TransportationAppointmentDriverLog transportationAppointmentDriverLog = new TransportationAppointmentDriverLog();
            transportationAppointmentDriverLog.DataAreaId = dataAreaId;
            transportationAppointmentDriverLog.AppointmentId = appointmentId;
            transportationAppointmentDriverLog.ActualAppointmentEndDateTime = actualAppointmentEndDateTime;
            transportationAppointmentDriverLog.ActualAppointmentStartDateTime = actualAppointmentStartDateTime;
            return transportationAppointmentDriverLog;
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
        /// There are no comments for Property AppointmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AppointmentId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AppointmentId is required.")]
        public virtual string AppointmentId
        {
            get
            {
                return this._AppointmentId;
            }
            set
            {
                this.OnAppointmentIdChanging(value);
                this._AppointmentId = value;
                this.OnAppointmentIdChanged();
                this.OnPropertyChanged("AppointmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AppointmentId;
        partial void OnAppointmentIdChanging(string value);
        partial void OnAppointmentIdChanged();
        /// <summary>
        /// There are no comments for Property ShippingCarrierVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingCarrierVendorAccountNumber")]
        public virtual string ShippingCarrierVendorAccountNumber
        {
            get
            {
                return this._ShippingCarrierVendorAccountNumber;
            }
            set
            {
                this.OnShippingCarrierVendorAccountNumberChanging(value);
                this._ShippingCarrierVendorAccountNumber = value;
                this.OnShippingCarrierVendorAccountNumberChanged();
                this.OnPropertyChanged("ShippingCarrierVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingCarrierVendorAccountNumber;
        partial void OnShippingCarrierVendorAccountNumberChanging(string value);
        partial void OnShippingCarrierVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property IsDropTrailerAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDropTrailerAllowed")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDropTrailerAllowed
        {
            get
            {
                return this._IsDropTrailerAllowed;
            }
            set
            {
                this.OnIsDropTrailerAllowedChanging(value);
                this._IsDropTrailerAllowed = value;
                this.OnIsDropTrailerAllowedChanged();
                this.OnPropertyChanged("IsDropTrailerAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDropTrailerAllowed;
        partial void OnIsDropTrailerAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDropTrailerAllowedChanged();
        /// <summary>
        /// There are no comments for Property ActualAppointmentEndDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualAppointmentEndDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualAppointmentEndDateTime is required.")]
        public virtual global::System.DateTimeOffset ActualAppointmentEndDateTime
        {
            get
            {
                return this._ActualAppointmentEndDateTime;
            }
            set
            {
                this.OnActualAppointmentEndDateTimeChanging(value);
                this._ActualAppointmentEndDateTime = value;
                this.OnActualAppointmentEndDateTimeChanged();
                this.OnPropertyChanged("ActualAppointmentEndDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActualAppointmentEndDateTime;
        partial void OnActualAppointmentEndDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnActualAppointmentEndDateTimeChanged();
        /// <summary>
        /// There are no comments for Property DriverLicense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DriverLicense")]
        public virtual string DriverLicense
        {
            get
            {
                return this._DriverLicense;
            }
            set
            {
                this.OnDriverLicenseChanging(value);
                this._DriverLicense = value;
                this.OnDriverLicenseChanged();
                this.OnPropertyChanged("DriverLicense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DriverLicense;
        partial void OnDriverLicenseChanging(string value);
        partial void OnDriverLicenseChanged();
        /// <summary>
        /// There are no comments for Property TransportationAppointmentAlertRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransportationAppointmentAlertRule")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TMSAppointmentAlert> TransportationAppointmentAlertRule
        {
            get
            {
                return this._TransportationAppointmentAlertRule;
            }
            set
            {
                this.OnTransportationAppointmentAlertRuleChanging(value);
                this._TransportationAppointmentAlertRule = value;
                this.OnTransportationAppointmentAlertRuleChanged();
                this.OnPropertyChanged("TransportationAppointmentAlertRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TMSAppointmentAlert> _TransportationAppointmentAlertRule;
        partial void OnTransportationAppointmentAlertRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TMSAppointmentAlert> value);
        partial void OnTransportationAppointmentAlertRuleChanged();
        /// <summary>
        /// There are no comments for Property ActualAppointmentStartDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualAppointmentStartDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActualAppointmentStartDateTime is required.")]
        public virtual global::System.DateTimeOffset ActualAppointmentStartDateTime
        {
            get
            {
                return this._ActualAppointmentStartDateTime;
            }
            set
            {
                this.OnActualAppointmentStartDateTimeChanging(value);
                this._ActualAppointmentStartDateTime = value;
                this.OnActualAppointmentStartDateTimeChanged();
                this.OnPropertyChanged("ActualAppointmentStartDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActualAppointmentStartDateTime;
        partial void OnActualAppointmentStartDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnActualAppointmentStartDateTimeChanged();
        /// <summary>
        /// There are no comments for Property DriverName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DriverName")]
        public virtual string DriverName
        {
            get
            {
                return this._DriverName;
            }
            set
            {
                this.OnDriverNameChanging(value);
                this._DriverName = value;
                this.OnDriverNameChanged();
                this.OnPropertyChanged("DriverName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DriverName;
        partial void OnDriverNameChanging(string value);
        partial void OnDriverNameChanged();
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
