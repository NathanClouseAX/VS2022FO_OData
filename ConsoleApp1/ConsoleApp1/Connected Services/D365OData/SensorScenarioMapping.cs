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
    /// There are no comments for SensorScenarioMappingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SensorScenarioMappingSingle")]
    public partial class SensorScenarioMappingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SensorScenarioMapping>
    {
        /// <summary>
        /// Initialize a new SensorScenarioMappingSingle object.
        /// </summary>
        public SensorScenarioMappingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SensorScenarioMappingSingle object.
        /// </summary>
        public SensorScenarioMappingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SensorScenarioMappingSingle object.
        /// </summary>
        public SensorScenarioMappingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SensorScenarioMapping> query)
            : base(query) {}

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
    /// There are no comments for SensorScenarioMapping in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SensorId
    /// Scenario
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("SensorId", "Scenario")]
    [global::Microsoft.OData.Client.EntitySet("SensorScenarioMappings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SensorScenarioMapping")]
    public partial class SensorScenarioMapping : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SensorScenarioMapping object.
        /// </summary>
        /// <param name="sensorId">Initial value of SensorId.</param>
        /// <param name="sensor">Initial value of Sensor.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SensorScenarioMapping CreateSensorScenarioMapping(string sensorId, global::Microsoft.Dynamics.DataEntities.Sensor sensor)
        {
            SensorScenarioMapping sensorScenarioMapping = new SensorScenarioMapping();
            sensorScenarioMapping.SensorId = sensorId;
            if ((sensor == null))
            {
                throw new global::System.ArgumentNullException("sensor");
            }
            sensorScenarioMapping.Sensor = sensor;
            return sensorScenarioMapping;
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
        /// There are no comments for Property Scenario in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Scenario")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IoTIntCoreScenarioType> Scenario
        {
            get
            {
                return this._Scenario;
            }
            set
            {
                this.OnScenarioChanging(value);
                this._Scenario = value;
                this.OnScenarioChanged();
                this.OnPropertyChanged("Scenario");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IoTIntCoreScenarioType> _Scenario;
        partial void OnScenarioChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.IoTIntCoreScenarioType> value);
        partial void OnScenarioChanged();
        /// <summary>
        /// There are no comments for Property IsSensorActiveForScenario in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsSensorActiveForScenario")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSensorActiveForScenario
        {
            get
            {
                return this._IsSensorActiveForScenario;
            }
            set
            {
                this.OnIsSensorActiveForScenarioChanging(value);
                this._IsSensorActiveForScenario = value;
                this.OnIsSensorActiveForScenarioChanged();
                this.OnPropertyChanged("IsSensorActiveForScenario");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSensorActiveForScenario;
        partial void OnIsSensorActiveForScenarioChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSensorActiveForScenarioChanged();
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
