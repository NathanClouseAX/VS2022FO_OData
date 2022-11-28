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
    /// There are no comments for PerformanceJournalEntryUrlLinksSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntryUrlLinksSingle")]
    public partial class PerformanceJournalEntryUrlLinksSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PerformanceJournalEntryUrlLinks>
    {
        /// <summary>
        /// Initialize a new PerformanceJournalEntryUrlLinksSingle object.
        /// </summary>
        public PerformanceJournalEntryUrlLinksSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PerformanceJournalEntryUrlLinksSingle object.
        /// </summary>
        public PerformanceJournalEntryUrlLinksSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PerformanceJournalEntryUrlLinksSingle object.
        /// </summary>
        public PerformanceJournalEntryUrlLinksSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PerformanceJournalEntryUrlLinks> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PerformanceJournalEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntry")]
        public virtual global::Microsoft.Dynamics.DataEntities.PerformanceJournalSingle PerformanceJournalEntry
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PerformanceJournalEntry == null))
                {
                    this._PerformanceJournalEntry = new global::Microsoft.Dynamics.DataEntities.PerformanceJournalSingle(this.Context, GetPath("PerformanceJournalEntry"));
                }
                return this._PerformanceJournalEntry;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PerformanceJournalSingle _PerformanceJournalEntry;
    }
    /// <summary>
    /// There are no comments for PerformanceJournalEntryUrlLinks in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LinkId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LinkId")]
    [global::Microsoft.OData.Client.EntitySet("PerformanceJournalEntryUrlLink")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntryUrlLinks")]
    public partial class PerformanceJournalEntryUrlLinks : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PerformanceJournalEntryUrlLinks object.
        /// </summary>
        /// <param name="linkId">Initial value of LinkId.</param>
        /// <param name="performanceJournalEntryId">Initial value of PerformanceJournalEntryId.</param>
        /// <param name="performanceJournalEntry">Initial value of PerformanceJournalEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PerformanceJournalEntryUrlLinks CreatePerformanceJournalEntryUrlLinks(global::System.Guid linkId, global::System.Guid performanceJournalEntryId, global::Microsoft.Dynamics.DataEntities.PerformanceJournal performanceJournalEntry)
        {
            PerformanceJournalEntryUrlLinks performanceJournalEntryUrlLinks = new PerformanceJournalEntryUrlLinks();
            performanceJournalEntryUrlLinks.LinkId = linkId;
            performanceJournalEntryUrlLinks.PerformanceJournalEntryId = performanceJournalEntryId;
            if ((performanceJournalEntry == null))
            {
                throw new global::System.ArgumentNullException("performanceJournalEntry");
            }
            performanceJournalEntryUrlLinks.PerformanceJournalEntry = performanceJournalEntry;
            return performanceJournalEntryUrlLinks;
        }
        /// <summary>
        /// There are no comments for Property LinkId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LinkId is required.")]
        public virtual global::System.Guid LinkId
        {
            get
            {
                return this._LinkId;
            }
            set
            {
                this.OnLinkIdChanging(value);
                this._LinkId = value;
                this.OnLinkIdChanged();
                this.OnPropertyChanged("LinkId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _LinkId;
        partial void OnLinkIdChanging(global::System.Guid value);
        partial void OnLinkIdChanged();
        /// <summary>
        /// There are no comments for Property URL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("URL")]
        public virtual string URL
        {
            get
            {
                return this._URL;
            }
            set
            {
                this.OnURLChanging(value);
                this._URL = value;
                this.OnURLChanged();
                this.OnPropertyChanged("URL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _URL;
        partial void OnURLChanging(string value);
        partial void OnURLChanged();
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
        /// There are no comments for Property PerformanceJournalEntryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntryId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PerformanceJournalEntryId is required.")]
        public virtual global::System.Guid PerformanceJournalEntryId
        {
            get
            {
                return this._PerformanceJournalEntryId;
            }
            set
            {
                this.OnPerformanceJournalEntryIdChanging(value);
                this._PerformanceJournalEntryId = value;
                this.OnPerformanceJournalEntryIdChanged();
                this.OnPropertyChanged("PerformanceJournalEntryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _PerformanceJournalEntryId;
        partial void OnPerformanceJournalEntryIdChanging(global::System.Guid value);
        partial void OnPerformanceJournalEntryIdChanged();
        /// <summary>
        /// There are no comments for Property PerformanceJournalEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PerformanceJournalEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PerformanceJournalEntry is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.PerformanceJournal PerformanceJournalEntry
        {
            get
            {
                return this._PerformanceJournalEntry;
            }
            set
            {
                this.OnPerformanceJournalEntryChanging(value);
                this._PerformanceJournalEntry = value;
                this.OnPerformanceJournalEntryChanged();
                this.OnPropertyChanged("PerformanceJournalEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PerformanceJournal _PerformanceJournalEntry;
        partial void OnPerformanceJournalEntryChanging(global::Microsoft.Dynamics.DataEntities.PerformanceJournal value);
        partial void OnPerformanceJournalEntryChanged();
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
