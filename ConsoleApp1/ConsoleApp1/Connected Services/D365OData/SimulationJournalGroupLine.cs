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
    /// There are no comments for SimulationJournalGroupLineSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SimulationJournalGroupLineSingle")]
    public partial class SimulationJournalGroupLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SimulationJournalGroupLine>
    {
        /// <summary>
        /// Initialize a new SimulationJournalGroupLineSingle object.
        /// </summary>
        public SimulationJournalGroupLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SimulationJournalGroupLineSingle object.
        /// </summary>
        public SimulationJournalGroupLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SimulationJournalGroupLineSingle object.
        /// </summary>
        public SimulationJournalGroupLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SimulationJournalGroupLine> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SimulationJournalGroupLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SimulationJournalGroupId
    /// JournalName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SimulationJournalGroupId", "JournalName")]
    [global::Microsoft.OData.Client.EntitySet("SimulationJournalGroupLines")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SimulationJournalGroupLine")]
    public partial class SimulationJournalGroupLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SimulationJournalGroupLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="simulationJournalGroupId">Initial value of SimulationJournalGroupId.</param>
        /// <param name="journalName">Initial value of JournalName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SimulationJournalGroupLine CreateSimulationJournalGroupLine(string dataAreaId, string simulationJournalGroupId, string journalName)
        {
            SimulationJournalGroupLine simulationJournalGroupLine = new SimulationJournalGroupLine();
            simulationJournalGroupLine.DataAreaId = dataAreaId;
            simulationJournalGroupLine.SimulationJournalGroupId = simulationJournalGroupId;
            simulationJournalGroupLine.JournalName = journalName;
            return simulationJournalGroupLine;
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
        /// There are no comments for Property SimulationJournalGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SimulationJournalGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SimulationJournalGroupId is required.")]
        public virtual string SimulationJournalGroupId
        {
            get
            {
                return this._SimulationJournalGroupId;
            }
            set
            {
                this.OnSimulationJournalGroupIdChanging(value);
                this._SimulationJournalGroupId = value;
                this.OnSimulationJournalGroupIdChanged();
                this.OnPropertyChanged("SimulationJournalGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SimulationJournalGroupId;
        partial void OnSimulationJournalGroupIdChanging(string value);
        partial void OnSimulationJournalGroupIdChanged();
        /// <summary>
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "JournalName is required.")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
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