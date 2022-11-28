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
    /// There are no comments for RetailDeviceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDeviceSingle")]
    public partial class RetailDeviceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDevice>
    {
        /// <summary>
        /// Initialize a new RetailDeviceSingle object.
        /// </summary>
        public RetailDeviceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailDeviceSingle object.
        /// </summary>
        public RetailDeviceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailDeviceSingle object.
        /// </summary>
        public RetailDeviceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailDevice> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailDevice in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DeviceId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DeviceId")]
    [global::Microsoft.OData.Client.EntitySet("RetailDevices")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDevice")]
    public partial class RetailDevice : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailDevice object.
        /// </summary>
        /// <param name="deviceId">Initial value of DeviceId.</param>
        /// <param name="mergedSelfServicePackageReference">Initial value of MergedSelfServicePackageReference.</param>
        /// <param name="retailDeviceType">Initial value of RetailDeviceType.</param>
        /// <param name="deactivatedDateTime">Initial value of DeactivatedDateTime.</param>
        /// <param name="activationGuid">Initial value of ActivationGuid.</param>
        /// <param name="activatedDateTime">Initial value of ActivatedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailDevice CreateRetailDevice(string deviceId, 
                    long mergedSelfServicePackageReference, 
                    int retailDeviceType, 
                    global::System.DateTimeOffset deactivatedDateTime, 
                    global::System.Guid activationGuid, 
                    global::System.DateTimeOffset activatedDateTime)
        {
            RetailDevice retailDevice = new RetailDevice();
            retailDevice.DeviceId = deviceId;
            retailDevice.MergedSelfServicePackageReference = mergedSelfServicePackageReference;
            retailDevice.RetailDeviceType = retailDeviceType;
            retailDevice.DeactivatedDateTime = deactivatedDateTime;
            retailDevice.ActivationGuid = activationGuid;
            retailDevice.ActivatedDateTime = activatedDateTime;
            return retailDevice;
        }
        /// <summary>
        /// There are no comments for Property DeviceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeviceId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeviceId is required.")]
        public virtual string DeviceId
        {
            get
            {
                return this._DeviceId;
            }
            set
            {
                this.OnDeviceIdChanging(value);
                this._DeviceId = value;
                this.OnDeviceIdChanged();
                this.OnPropertyChanged("DeviceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeviceId;
        partial void OnDeviceIdChanging(string value);
        partial void OnDeviceIdChanged();
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
        /// There are no comments for Property MergedSelfServicePackageReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MergedSelfServicePackageReference")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MergedSelfServicePackageReference is required.")]
        public virtual long MergedSelfServicePackageReference
        {
            get
            {
                return this._MergedSelfServicePackageReference;
            }
            set
            {
                this.OnMergedSelfServicePackageReferenceChanging(value);
                this._MergedSelfServicePackageReference = value;
                this.OnMergedSelfServicePackageReferenceChanged();
                this.OnPropertyChanged("MergedSelfServicePackageReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _MergedSelfServicePackageReference;
        partial void OnMergedSelfServicePackageReferenceChanging(long value);
        partial void OnMergedSelfServicePackageReferenceChanged();
        /// <summary>
        /// There are no comments for Property RetailDeviceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailDeviceType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailDeviceType is required.")]
        public virtual int RetailDeviceType
        {
            get
            {
                return this._RetailDeviceType;
            }
            set
            {
                this.OnRetailDeviceTypeChanging(value);
                this._RetailDeviceType = value;
                this.OnRetailDeviceTypeChanged();
                this.OnPropertyChanged("RetailDeviceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RetailDeviceType;
        partial void OnRetailDeviceTypeChanging(int value);
        partial void OnRetailDeviceTypeChanged();
        /// <summary>
        /// There are no comments for Property AllowMassActivation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowMassActivation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowMassActivation
        {
            get
            {
                return this._AllowMassActivation;
            }
            set
            {
                this.OnAllowMassActivationChanging(value);
                this._AllowMassActivation = value;
                this.OnAllowMassActivationChanged();
                this.OnPropertyChanged("AllowMassActivation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowMassActivation;
        partial void OnAllowMassActivationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowMassActivationChanged();
        /// <summary>
        /// There are no comments for Property DeactivatedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeactivatedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeactivatedDateTime is required.")]
        public virtual global::System.DateTimeOffset DeactivatedDateTime
        {
            get
            {
                return this._DeactivatedDateTime;
            }
            set
            {
                this.OnDeactivatedDateTimeChanging(value);
                this._DeactivatedDateTime = value;
                this.OnDeactivatedDateTimeChanged();
                this.OnPropertyChanged("DeactivatedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DeactivatedDateTime;
        partial void OnDeactivatedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnDeactivatedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ActivationStaffId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivationStaffId")]
        public virtual string ActivationStaffId
        {
            get
            {
                return this._ActivationStaffId;
            }
            set
            {
                this.OnActivationStaffIdChanging(value);
                this._ActivationStaffId = value;
                this.OnActivationStaffIdChanged();
                this.OnPropertyChanged("ActivationStaffId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivationStaffId;
        partial void OnActivationStaffIdChanging(string value);
        partial void OnActivationStaffIdChanged();
        /// <summary>
        /// There are no comments for Property Terminal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Terminal")]
        public virtual string Terminal
        {
            get
            {
                return this._Terminal;
            }
            set
            {
                this.OnTerminalChanging(value);
                this._Terminal = value;
                this.OnTerminalChanged();
                this.OnPropertyChanged("Terminal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Terminal;
        partial void OnTerminalChanging(string value);
        partial void OnTerminalChanged();
        /// <summary>
        /// There are no comments for Property PhysicalDeviceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PhysicalDeviceId")]
        public virtual string PhysicalDeviceId
        {
            get
            {
                return this._PhysicalDeviceId;
            }
            set
            {
                this.OnPhysicalDeviceIdChanging(value);
                this._PhysicalDeviceId = value;
                this.OnPhysicalDeviceIdChanged();
                this.OnPropertyChanged("PhysicalDeviceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PhysicalDeviceId;
        partial void OnPhysicalDeviceIdChanging(string value);
        partial void OnPhysicalDeviceIdChanged();
        /// <summary>
        /// There are no comments for Property ActivationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivationStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDeviceActivationStatusBase> ActivationStatus
        {
            get
            {
                return this._ActivationStatus;
            }
            set
            {
                this.OnActivationStatusChanging(value);
                this._ActivationStatus = value;
                this.OnActivationStatusChanged();
                this.OnPropertyChanged("ActivationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDeviceActivationStatusBase> _ActivationStatus;
        partial void OnActivationStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDeviceActivationStatusBase> value);
        partial void OnActivationStatusChanged();
        /// <summary>
        /// There are no comments for Property DeactivationStaffId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeactivationStaffId")]
        public virtual string DeactivationStaffId
        {
            get
            {
                return this._DeactivationStaffId;
            }
            set
            {
                this.OnDeactivationStaffIdChanging(value);
                this._DeactivationStaffId = value;
                this.OnDeactivationStaffIdChanged();
                this.OnPropertyChanged("DeactivationStaffId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeactivationStaffId;
        partial void OnDeactivationStaffIdChanging(string value);
        partial void OnDeactivationStaffIdChanged();
        /// <summary>
        /// There are no comments for Property DeactivateComments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeactivateComments")]
        public virtual string DeactivateComments
        {
            get
            {
                return this._DeactivateComments;
            }
            set
            {
                this.OnDeactivateCommentsChanging(value);
                this._DeactivateComments = value;
                this.OnDeactivateCommentsChanged();
                this.OnPropertyChanged("DeactivateComments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeactivateComments;
        partial void OnDeactivateCommentsChanging(string value);
        partial void OnDeactivateCommentsChanged();
        /// <summary>
        /// There are no comments for Property ActivationGuid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivationGuid")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActivationGuid is required.")]
        public virtual global::System.Guid ActivationGuid
        {
            get
            {
                return this._ActivationGuid;
            }
            set
            {
                this.OnActivationGuidChanging(value);
                this._ActivationGuid = value;
                this.OnActivationGuidChanged();
                this.OnPropertyChanged("ActivationGuid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ActivationGuid;
        partial void OnActivationGuidChanging(global::System.Guid value);
        partial void OnActivationGuidChanged();
        /// <summary>
        /// There are no comments for Property ActivatedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivatedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActivatedDateTime is required.")]
        public virtual global::System.DateTimeOffset ActivatedDateTime
        {
            get
            {
                return this._ActivatedDateTime;
            }
            set
            {
                this.OnActivatedDateTimeChanging(value);
                this._ActivatedDateTime = value;
                this.OnActivatedDateTimeChanged();
                this.OnPropertyChanged("ActivatedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActivatedDateTime;
        partial void OnActivatedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnActivatedDateTimeChanged();
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
