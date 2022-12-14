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
    /// There are no comments for SensorMaintenanceAssetCounterMappingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SensorMaintenanceAssetCounterMappingSingle")]
    public partial class SensorMaintenanceAssetCounterMappingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SensorMaintenanceAssetCounterMapping>
    {
        /// <summary>
        /// Initialize a new SensorMaintenanceAssetCounterMappingSingle object.
        /// </summary>
        public SensorMaintenanceAssetCounterMappingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SensorMaintenanceAssetCounterMappingSingle object.
        /// </summary>
        public SensorMaintenanceAssetCounterMappingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SensorMaintenanceAssetCounterMappingSingle object.
        /// </summary>
        public SensorMaintenanceAssetCounterMappingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SensorMaintenanceAssetCounterMapping> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for MaintenanceAssetCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetCounter")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounterSingle MaintenanceAssetCounter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MaintenanceAssetCounter == null))
                {
                    this._MaintenanceAssetCounter = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounterSingle(this.Context, GetPath("MaintenanceAssetCounter"));
                }
                return this._MaintenanceAssetCounter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounterSingle _MaintenanceAssetCounter;
        /// <summary>
        /// There are no comments for Sensor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Sensor")]
        public virtual global::Microsoft.Dynamics.DataEntities.SensorSingle Sensor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Sensor == null))
                {
                    this._Sensor = new global::Microsoft.Dynamics.DataEntities.SensorSingle(this.Context, GetPath("Sensor"));
                }
                return this._Sensor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SensorSingle _Sensor;
    }
    /// <summary>
    /// There are no comments for SensorMaintenanceAssetCounterMapping in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SensorId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("SensorId")]
    [global::Microsoft.OData.Client.EntitySet("SensorMaintenanceAssetCounterMappings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SensorMaintenanceAssetCounterMapping")]
    public partial class SensorMaintenanceAssetCounterMapping : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SensorMaintenanceAssetCounterMapping object.
        /// </summary>
        /// <param name="sensorId">Initial value of SensorId.</param>
        /// <param name="maintenanceAssetCounter">Initial value of MaintenanceAssetCounter.</param>
        /// <param name="sensor">Initial value of Sensor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SensorMaintenanceAssetCounterMapping CreateSensorMaintenanceAssetCounterMapping(string sensorId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter maintenanceAssetCounter, global::Microsoft.Dynamics.DataEntities.Sensor sensor)
        {
            SensorMaintenanceAssetCounterMapping sensorMaintenanceAssetCounterMapping = new SensorMaintenanceAssetCounterMapping();
            sensorMaintenanceAssetCounterMapping.SensorId = sensorId;
            if ((maintenanceAssetCounter == null))
            {
                throw new global::System.ArgumentNullException("maintenanceAssetCounter");
            }
            sensorMaintenanceAssetCounterMapping.MaintenanceAssetCounter = maintenanceAssetCounter;
            if ((sensor == null))
            {
                throw new global::System.ArgumentNullException("sensor");
            }
            sensorMaintenanceAssetCounterMapping.Sensor = sensor;
            return sensorMaintenanceAssetCounterMapping;
        }
        /// <summary>
        /// There are no comments for Property SensorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SensorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SensorId is required.")]
        public virtual string SensorId
        {
            get
            {
                return this._SensorId;
            }
            set
            {
                this.OnSensorIdChanging(value);
                this._SensorId = value;
                this.OnSensorIdChanged();
                this.OnPropertyChanged("SensorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SensorId;
        partial void OnSensorIdChanging(string value);
        partial void OnSensorIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetCounterId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetCounterId")]
        public virtual string MaintenanceAssetCounterId
        {
            get
            {
                return this._MaintenanceAssetCounterId;
            }
            set
            {
                this.OnMaintenanceAssetCounterIdChanging(value);
                this._MaintenanceAssetCounterId = value;
                this.OnMaintenanceAssetCounterIdChanged();
                this.OnPropertyChanged("MaintenanceAssetCounterId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetCounterId;
        partial void OnMaintenanceAssetCounterIdChanging(string value);
        partial void OnMaintenanceAssetCounterIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetCounterDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetCounterDataAreaId")]
        public virtual string MaintenanceAssetCounterDataAreaId
        {
            get
            {
                return this._MaintenanceAssetCounterDataAreaId;
            }
            set
            {
                this.OnMaintenanceAssetCounterDataAreaIdChanging(value);
                this._MaintenanceAssetCounterDataAreaId = value;
                this.OnMaintenanceAssetCounterDataAreaIdChanged();
                this.OnPropertyChanged("MaintenanceAssetCounterDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceAssetCounterDataAreaId;
        partial void OnMaintenanceAssetCounterDataAreaIdChanging(string value);
        partial void OnMaintenanceAssetCounterDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceAssetCounter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaintenanceAssetCounter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaintenanceAssetCounter is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter MaintenanceAssetCounter
        {
            get
            {
                return this._MaintenanceAssetCounter;
            }
            set
            {
                this.OnMaintenanceAssetCounterChanging(value);
                this._MaintenanceAssetCounter = value;
                this.OnMaintenanceAssetCounterChanged();
                this.OnPropertyChanged("MaintenanceAssetCounter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter _MaintenanceAssetCounter;
        partial void OnMaintenanceAssetCounterChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCounter value);
        partial void OnMaintenanceAssetCounterChanged();
        /// <summary>
        /// There are no comments for Property Sensor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Sensor")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Sensor is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Sensor Sensor
        {
            get
            {
                return this._Sensor;
            }
            set
            {
                this.OnSensorChanging(value);
                this._Sensor = value;
                this.OnSensorChanged();
                this.OnPropertyChanged("Sensor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Sensor _Sensor;
        partial void OnSensorChanging(global::Microsoft.Dynamics.DataEntities.Sensor value);
        partial void OnSensorChanged();
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
