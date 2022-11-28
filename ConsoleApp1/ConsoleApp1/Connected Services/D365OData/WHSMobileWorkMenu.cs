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
    /// There are no comments for WHSMobileWorkMenuSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WHSMobileWorkMenuSingle")]
    public partial class WHSMobileWorkMenuSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WHSMobileWorkMenu>
    {
        /// <summary>
        /// Initialize a new WHSMobileWorkMenuSingle object.
        /// </summary>
        public WHSMobileWorkMenuSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WHSMobileWorkMenuSingle object.
        /// </summary>
        public WHSMobileWorkMenuSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WHSMobileWorkMenuSingle object.
        /// </summary>
        public WHSMobileWorkMenuSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WHSMobileWorkMenu> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for MenuItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuItems")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem> MenuItems
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._MenuItems == null))
                {
                    this._MenuItems = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem>(GetPath("MenuItems"));
                }
                return this._MenuItems;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem> _MenuItems;
        /// <summary>
        /// There are no comments for Session in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Session")]
        public virtual global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSessionSingle Session
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Session == null))
                {
                    this._Session = new global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSessionSingle(this.Context, GetPath("Session"));
                }
                return this._Session;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSessionSingle _Session;
    }
    /// <summary>
    /// There are no comments for WHSMobileWorkMenu in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RecordId")]
    [global::Microsoft.OData.Client.EntitySet("WHSMobileWorkMenus")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WHSMobileWorkMenu")]
    public partial class WHSMobileWorkMenu : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WHSMobileWorkMenu object.
        /// </summary>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="sessionRecId">Initial value of SessionRecId.</param>
        /// <param name="session">Initial value of Session.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WHSMobileWorkMenu CreateWHSMobileWorkMenu(long recordId, long sessionRecId, global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSession session)
        {
            WHSMobileWorkMenu wHSMobileWorkMenu = new WHSMobileWorkMenu();
            wHSMobileWorkMenu.RecordId = recordId;
            wHSMobileWorkMenu.SessionRecId = sessionRecId;
            if ((session == null))
            {
                throw new global::System.ArgumentNullException("session");
            }
            wHSMobileWorkMenu.Session = session;
            return wHSMobileWorkMenu;
        }
        /// <summary>
        /// There are no comments for Property RecordId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecordId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RecordId is required.")]
        public virtual long RecordId
        {
            get
            {
                return this._RecordId;
            }
            set
            {
                this.OnRecordIdChanging(value);
                this._RecordId = value;
                this.OnRecordIdChanged();
                this.OnPropertyChanged("RecordId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _RecordId;
        partial void OnRecordIdChanging(long value);
        partial void OnRecordIdChanged();
        /// <summary>
        /// There are no comments for Property SessionRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SessionRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SessionRecId is required.")]
        public virtual long SessionRecId
        {
            get
            {
                return this._SessionRecId;
            }
            set
            {
                this.OnSessionRecIdChanging(value);
                this._SessionRecId = value;
                this.OnSessionRecIdChanged();
                this.OnPropertyChanged("SessionRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SessionRecId;
        partial void OnSessionRecIdChanging(long value);
        partial void OnSessionRecIdChanged();
        /// <summary>
        /// There are no comments for Property SubmissionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubmissionType")]
        public virtual string SubmissionType
        {
            get
            {
                return this._SubmissionType;
            }
            set
            {
                this.OnSubmissionTypeChanging(value);
                this._SubmissionType = value;
                this.OnSubmissionTypeChanged();
                this.OnPropertyChanged("SubmissionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubmissionType;
        partial void OnSubmissionTypeChanging(string value);
        partial void OnSubmissionTypeChanged();
        /// <summary>
        /// There are no comments for Property Label in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Label")]
        public virtual string Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                this.OnLabelChanging(value);
                this._Label = value;
                this.OnLabelChanged();
                this.OnPropertyChanged("Label");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Label;
        partial void OnLabelChanging(string value);
        partial void OnLabelChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property MenuItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuItems")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem> MenuItems
        {
            get
            {
                return this._MenuItems;
            }
            set
            {
                this.OnMenuItemsChanging(value);
                this._MenuItems = value;
                this.OnMenuItemsChanged();
                this.OnPropertyChanged("MenuItems");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem> _MenuItems = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnMenuItemsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuItem> value);
        partial void OnMenuItemsChanged();
        /// <summary>
        /// There are no comments for Property Session in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Session")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Session is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSession Session
        {
            get
            {
                return this._Session;
            }
            set
            {
                this.OnSessionChanging(value);
                this._Session = value;
                this.OnSessionChanged();
                this.OnPropertyChanged("Session");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSession _Session;
        partial void OnSessionChanging(global::Microsoft.Dynamics.DataEntities.WHSMobileWorkSession value);
        partial void OnSessionChanged();
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