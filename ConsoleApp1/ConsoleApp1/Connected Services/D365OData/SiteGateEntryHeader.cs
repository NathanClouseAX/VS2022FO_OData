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
    /// There are no comments for SiteGateEntryHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SiteGateEntryHeaderSingle")]
    public partial class SiteGateEntryHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SiteGateEntryHeader>
    {
        /// <summary>
        /// Initialize a new SiteGateEntryHeaderSingle object.
        /// </summary>
        public SiteGateEntryHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SiteGateEntryHeaderSingle object.
        /// </summary>
        public SiteGateEntryHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SiteGateEntryHeaderSingle object.
        /// </summary>
        public SiteGateEntryHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SiteGateEntryHeader> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SiteGateEntryHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// GateEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GateEntry")]
    [global::Microsoft.OData.Client.EntitySet("SiteGateEntryHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SiteGateEntryHeader")]
    public partial class SiteGateEntryHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SiteGateEntryHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="gateEntry">Initial value of GateEntry.</param>
        /// <param name="transportationReceiptDate">Initial value of TransportationReceiptDate.</param>
        /// <param name="arrivalDateAndTime">Initial value of ArrivalDateAndTime.</param>
        /// <param name="challanDate">Initial value of ChallanDate.</param>
        /// <param name="exitDateAndTime">Initial value of ExitDateAndTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SiteGateEntryHeader CreateSiteGateEntryHeader(string dataAreaId, 
                    string gateEntry, 
                    global::System.DateTimeOffset transportationReceiptDate, 
                    global::System.DateTimeOffset arrivalDateAndTime, 
                    global::System.DateTimeOffset challanDate, 
                    global::System.DateTimeOffset exitDateAndTime)
        {
            SiteGateEntryHeader siteGateEntryHeader = new SiteGateEntryHeader();
            siteGateEntryHeader.DataAreaId = dataAreaId;
            siteGateEntryHeader.GateEntry = gateEntry;
            siteGateEntryHeader.TransportationReceiptDate = transportationReceiptDate;
            siteGateEntryHeader.ArrivalDateAndTime = arrivalDateAndTime;
            siteGateEntryHeader.ChallanDate = challanDate;
            siteGateEntryHeader.ExitDateAndTime = exitDateAndTime;
            return siteGateEntryHeader;
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
        /// There are no comments for Property GateEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GateEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GateEntry is required.")]
        public virtual string GateEntry
        {
            get
            {
                return this._GateEntry;
            }
            set
            {
                this.OnGateEntryChanging(value);
                this._GateEntry = value;
                this.OnGateEntryChanged();
                this.OnPropertyChanged("GateEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GateEntry;
        partial void OnGateEntryChanging(string value);
        partial void OnGateEntryChanged();
        /// <summary>
        /// There are no comments for Property TransportationReceiptDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransportationReceiptDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TransportationReceiptDate is required.")]
        public virtual global::System.DateTimeOffset TransportationReceiptDate
        {
            get
            {
                return this._TransportationReceiptDate;
            }
            set
            {
                this.OnTransportationReceiptDateChanging(value);
                this._TransportationReceiptDate = value;
                this.OnTransportationReceiptDateChanged();
                this.OnPropertyChanged("TransportationReceiptDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransportationReceiptDate;
        partial void OnTransportationReceiptDateChanging(global::System.DateTimeOffset value);
        partial void OnTransportationReceiptDateChanged();
        /// <summary>
        /// There are no comments for Property ArrivalDateAndTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ArrivalDateAndTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ArrivalDateAndTime is required.")]
        public virtual global::System.DateTimeOffset ArrivalDateAndTime
        {
            get
            {
                return this._ArrivalDateAndTime;
            }
            set
            {
                this.OnArrivalDateAndTimeChanging(value);
                this._ArrivalDateAndTime = value;
                this.OnArrivalDateAndTimeChanged();
                this.OnPropertyChanged("ArrivalDateAndTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ArrivalDateAndTime;
        partial void OnArrivalDateAndTimeChanging(global::System.DateTimeOffset value);
        partial void OnArrivalDateAndTimeChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateEntryStatus_IN> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateEntryStatus_IN> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateEntryStatus_IN> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property VehicleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VehicleNumber")]
        public virtual string VehicleNumber
        {
            get
            {
                return this._VehicleNumber;
            }
            set
            {
                this.OnVehicleNumberChanging(value);
                this._VehicleNumber = value;
                this.OnVehicleNumberChanged();
                this.OnPropertyChanged("VehicleNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VehicleNumber;
        partial void OnVehicleNumberChanging(string value);
        partial void OnVehicleNumberChanged();
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
        /// There are no comments for Property TransportationReceiptNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransportationReceiptNumber")]
        public virtual string TransportationReceiptNumber
        {
            get
            {
                return this._TransportationReceiptNumber;
            }
            set
            {
                this.OnTransportationReceiptNumberChanging(value);
                this._TransportationReceiptNumber = value;
                this.OnTransportationReceiptNumberChanged();
                this.OnPropertyChanged("TransportationReceiptNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransportationReceiptNumber;
        partial void OnTransportationReceiptNumberChanging(string value);
        partial void OnTransportationReceiptNumberChanged();
        /// <summary>
        /// There are no comments for Property ChallanDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChallanDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChallanDate is required.")]
        public virtual global::System.DateTimeOffset ChallanDate
        {
            get
            {
                return this._ChallanDate;
            }
            set
            {
                this.OnChallanDateChanging(value);
                this._ChallanDate = value;
                this.OnChallanDateChanged();
                this.OnPropertyChanged("ChallanDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ChallanDate;
        partial void OnChallanDateChanging(global::System.DateTimeOffset value);
        partial void OnChallanDateChanged();
        /// <summary>
        /// There are no comments for Property Transporter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Transporter")]
        public virtual string Transporter
        {
            get
            {
                return this._Transporter;
            }
            set
            {
                this.OnTransporterChanging(value);
                this._Transporter = value;
                this.OnTransporterChanged();
                this.OnPropertyChanged("Transporter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Transporter;
        partial void OnTransporterChanging(string value);
        partial void OnTransporterChanged();
        /// <summary>
        /// There are no comments for Property FactoryGate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FactoryGate")]
        public virtual string FactoryGate
        {
            get
            {
                return this._FactoryGate;
            }
            set
            {
                this.OnFactoryGateChanging(value);
                this._FactoryGate = value;
                this.OnFactoryGateChanged();
                this.OnPropertyChanged("FactoryGate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FactoryGate;
        partial void OnFactoryGateChanging(string value);
        partial void OnFactoryGateChanged();
        /// <summary>
        /// There are no comments for Property SkipMeasurement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SkipMeasurement")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SkipMeasurement
        {
            get
            {
                return this._SkipMeasurement;
            }
            set
            {
                this.OnSkipMeasurementChanging(value);
                this._SkipMeasurement = value;
                this.OnSkipMeasurementChanged();
                this.OnPropertyChanged("SkipMeasurement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SkipMeasurement;
        partial void OnSkipMeasurementChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSkipMeasurementChanged();
        /// <summary>
        /// There are no comments for Property RGPNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RGPNumber")]
        public virtual string RGPNumber
        {
            get
            {
                return this._RGPNumber;
            }
            set
            {
                this.OnRGPNumberChanging(value);
                this._RGPNumber = value;
                this.OnRGPNumberChanged();
                this.OnPropertyChanged("RGPNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RGPNumber;
        partial void OnRGPNumberChanging(string value);
        partial void OnRGPNumberChanged();
        /// <summary>
        /// There are no comments for Property ReferenceDocumentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceDocumentType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateRefDocType_IN> ReferenceDocumentType
        {
            get
            {
                return this._ReferenceDocumentType;
            }
            set
            {
                this.OnReferenceDocumentTypeChanging(value);
                this._ReferenceDocumentType = value;
                this.OnReferenceDocumentTypeChanged();
                this.OnPropertyChanged("ReferenceDocumentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateRefDocType_IN> _ReferenceDocumentType;
        partial void OnReferenceDocumentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateRefDocType_IN> value);
        partial void OnReferenceDocumentTypeChanged();
        /// <summary>
        /// There are no comments for Property GateEntryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GateEntryType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateEntryType_IN> GateEntryType
        {
            get
            {
                return this._GateEntryType;
            }
            set
            {
                this.OnGateEntryTypeChanging(value);
                this._GateEntryType = value;
                this.OnGateEntryTypeChanged();
                this.OnPropertyChanged("GateEntryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateEntryType_IN> _GateEntryType;
        partial void OnGateEntryTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.InventSiteGateEntryType_IN> value);
        partial void OnGateEntryTypeChanged();
        /// <summary>
        /// There are no comments for Property InventLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventLocationId")]
        public virtual string InventLocationId
        {
            get
            {
                return this._InventLocationId;
            }
            set
            {
                this.OnInventLocationIdChanging(value);
                this._InventLocationId = value;
                this.OnInventLocationIdChanged();
                this.OnPropertyChanged("InventLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventLocationId;
        partial void OnInventLocationIdChanging(string value);
        partial void OnInventLocationIdChanged();
        /// <summary>
        /// There are no comments for Property ReferenceParty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReferenceParty")]
        public virtual string ReferenceParty
        {
            get
            {
                return this._ReferenceParty;
            }
            set
            {
                this.OnReferencePartyChanging(value);
                this._ReferenceParty = value;
                this.OnReferencePartyChanged();
                this.OnPropertyChanged("ReferenceParty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReferenceParty;
        partial void OnReferencePartyChanging(string value);
        partial void OnReferencePartyChanged();
        /// <summary>
        /// There are no comments for Property ChallanNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChallanNumber")]
        public virtual string ChallanNumber
        {
            get
            {
                return this._ChallanNumber;
            }
            set
            {
                this.OnChallanNumberChanging(value);
                this._ChallanNumber = value;
                this.OnChallanNumberChanged();
                this.OnPropertyChanged("ChallanNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChallanNumber;
        partial void OnChallanNumberChanging(string value);
        partial void OnChallanNumberChanged();
        /// <summary>
        /// There are no comments for Property DriverMobilePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DriverMobilePhone")]
        public virtual string DriverMobilePhone
        {
            get
            {
                return this._DriverMobilePhone;
            }
            set
            {
                this.OnDriverMobilePhoneChanging(value);
                this._DriverMobilePhone = value;
                this.OnDriverMobilePhoneChanged();
                this.OnPropertyChanged("DriverMobilePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DriverMobilePhone;
        partial void OnDriverMobilePhoneChanging(string value);
        partial void OnDriverMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Worker")]
        public virtual string Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Worker;
        partial void OnWorkerChanging(string value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property Site in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Site")]
        public virtual string Site
        {
            get
            {
                return this._Site;
            }
            set
            {
                this.OnSiteChanging(value);
                this._Site = value;
                this.OnSiteChanged();
                this.OnPropertyChanged("Site");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Site;
        partial void OnSiteChanging(string value);
        partial void OnSiteChanged();
        /// <summary>
        /// There are no comments for Property Origin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Origin")]
        public virtual string Origin
        {
            get
            {
                return this._Origin;
            }
            set
            {
                this.OnOriginChanging(value);
                this._Origin = value;
                this.OnOriginChanged();
                this.OnPropertyChanged("Origin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Origin;
        partial void OnOriginChanging(string value);
        partial void OnOriginChanged();
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
        /// There are no comments for Property ExitDateAndTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExitDateAndTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExitDateAndTime is required.")]
        public virtual global::System.DateTimeOffset ExitDateAndTime
        {
            get
            {
                return this._ExitDateAndTime;
            }
            set
            {
                this.OnExitDateAndTimeChanging(value);
                this._ExitDateAndTime = value;
                this.OnExitDateAndTimeChanged();
                this.OnPropertyChanged("ExitDateAndTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExitDateAndTime;
        partial void OnExitDateAndTimeChanging(global::System.DateTimeOffset value);
        partial void OnExitDateAndTimeChanged();
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
