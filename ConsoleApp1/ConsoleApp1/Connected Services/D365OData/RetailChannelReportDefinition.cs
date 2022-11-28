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
    /// There are no comments for RetailChannelReportDefinitionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelReportDefinitionSingle")]
    public partial class RetailChannelReportDefinitionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelReportDefinition>
    {
        /// <summary>
        /// Initialize a new RetailChannelReportDefinitionSingle object.
        /// </summary>
        public RetailChannelReportDefinitionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailChannelReportDefinitionSingle object.
        /// </summary>
        public RetailChannelReportDefinitionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailChannelReportDefinitionSingle object.
        /// </summary>
        public RetailChannelReportDefinitionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelReportDefinition> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailChannelReportDefinition in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ReportId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ReportId")]
    [global::Microsoft.OData.Client.EntitySet("RetailChannelReportDefinitions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailChannelReportDefinition")]
    public partial class RetailChannelReportDefinition : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailChannelReportDefinition object.
        /// </summary>
        /// <param name="reportId">Initial value of ReportId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailChannelReportDefinition CreateRetailChannelReportDefinition(string reportId)
        {
            RetailChannelReportDefinition retailChannelReportDefinition = new RetailChannelReportDefinition();
            retailChannelReportDefinition.ReportId = reportId;
            return retailChannelReportDefinition;
        }
        /// <summary>
        /// There are no comments for Property ReportId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReportId is required.")]
        public virtual string ReportId
        {
            get
            {
                return this._ReportId;
            }
            set
            {
                this.OnReportIdChanging(value);
                this._ReportId = value;
                this.OnReportIdChanged();
                this.OnPropertyChanged("ReportId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportId;
        partial void OnReportIdChanging(string value);
        partial void OnReportIdChanged();
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
