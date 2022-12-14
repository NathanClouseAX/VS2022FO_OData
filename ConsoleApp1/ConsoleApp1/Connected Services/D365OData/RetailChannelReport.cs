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
    /// There are no comments for RetailChannelReportSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelReportSingle")]
    public partial class RetailChannelReportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelReport>
    {
        /// <summary>
        /// Initialize a new RetailChannelReportSingle object.
        /// </summary>
        public RetailChannelReportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailChannelReportSingle object.
        /// </summary>
        public RetailChannelReportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailChannelReportSingle object.
        /// </summary>
        public RetailChannelReportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelReport> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailTillLayoutReportZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTillLayoutReportZone")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> RetailTillLayoutReportZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutReportZone == null))
                {
                    this._RetailTillLayoutReportZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone>(GetPath("RetailTillLayoutReportZone"));
                }
                return this._RetailTillLayoutReportZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> _RetailTillLayoutReportZone;
    }
    /// <summary>
    /// There are no comments for RetailChannelReport in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ReportID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ReportID")]
    [global::Microsoft.OData.Client.EntitySet("RetailChannelReports")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelReport")]
    public partial class RetailChannelReport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailChannelReport object.
        /// </summary>
        /// <param name="reportID">Initial value of ReportID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailChannelReport CreateRetailChannelReport(string reportID)
        {
            RetailChannelReport retailChannelReport = new RetailChannelReport();
            retailChannelReport.ReportID = reportID;
            return retailChannelReport;
        }
        /// <summary>
        /// There are no comments for Property ReportID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReportID is required.")]
        public virtual string ReportID
        {
            get
            {
                return this._ReportID;
            }
            set
            {
                this.OnReportIDChanging(value);
                this._ReportID = value;
                this.OnReportIDChanged();
                this.OnPropertyChanged("ReportID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportID;
        partial void OnReportIDChanging(string value);
        partial void OnReportIDChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Version")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailChannelReportVersion> Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailChannelReportVersion> _Version;
        partial void OnVersionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailChannelReportVersion> value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property ReportName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportName")]
        public virtual string ReportName
        {
            get
            {
                return this._ReportName;
            }
            set
            {
                this.OnReportNameChanging(value);
                this._ReportName = value;
                this.OnReportNameChanged();
                this.OnPropertyChanged("ReportName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportName;
        partial void OnReportNameChanging(string value);
        partial void OnReportNameChanged();
        /// <summary>
        /// There are no comments for Property ReportDefinitionXML in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportDefinitionXML")]
        public virtual string ReportDefinitionXML
        {
            get
            {
                return this._ReportDefinitionXML;
            }
            set
            {
                this.OnReportDefinitionXMLChanging(value);
                this._ReportDefinitionXML = value;
                this.OnReportDefinitionXMLChanged();
                this.OnPropertyChanged("ReportDefinitionXML");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportDefinitionXML;
        partial void OnReportDefinitionXMLChanging(string value);
        partial void OnReportDefinitionXMLChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutReportZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RetailTillLayoutReportZone")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> RetailTillLayoutReportZone
        {
            get
            {
                return this._RetailTillLayoutReportZone;
            }
            set
            {
                this.OnRetailTillLayoutReportZoneChanging(value);
                this._RetailTillLayoutReportZone = value;
                this.OnRetailTillLayoutReportZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutReportZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> _RetailTillLayoutReportZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutReportZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> value);
        partial void OnRetailTillLayoutReportZoneChanged();
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
