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
    /// There are no comments for FiscalCalendarBiEntitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarBiEntitySingle")]
    public partial class FiscalCalendarBiEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendarBiEntity>
    {
        /// <summary>
        /// Initialize a new FiscalCalendarBiEntitySingle object.
        /// </summary>
        public FiscalCalendarBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalCalendarBiEntitySingle object.
        /// </summary>
        public FiscalCalendarBiEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalCalendarBiEntitySingle object.
        /// </summary>
        public FiscalCalendarBiEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalCalendarBiEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FiscalCalendarBiEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CalendarId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CalendarId")]
    [global::Microsoft.OData.Client.EntitySet("FiscalCalendarBiEntities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCalendarBiEntity")]
    public partial class FiscalCalendarBiEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalCalendarBiEntity object.
        /// </summary>
        /// <param name="calendarId">Initial value of CalendarId.</param>
        /// <param name="sysRowVersionNumber">Initial value of SysRowVersionNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalCalendarBiEntity CreateFiscalCalendarBiEntity(string calendarId, long sysRowVersionNumber)
        {
            FiscalCalendarBiEntity fiscalCalendarBiEntity = new FiscalCalendarBiEntity();
            fiscalCalendarBiEntity.CalendarId = calendarId;
            fiscalCalendarBiEntity.SysRowVersionNumber = sysRowVersionNumber;
            return fiscalCalendarBiEntity;
        }
        /// <summary>
        /// There are no comments for Property CalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalendarId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CalendarId is required.")]
        public virtual string CalendarId
        {
            get
            {
                return this._CalendarId;
            }
            set
            {
                this.OnCalendarIdChanging(value);
                this._CalendarId = value;
                this.OnCalendarIdChanged();
                this.OnPropertyChanged("CalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalendarId;
        partial void OnCalendarIdChanging(string value);
        partial void OnCalendarIdChanged();
        /// <summary>
        /// There are no comments for Property SysRowVersionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SysRowVersionNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SysRowVersionNumber is required.")]
        public virtual long SysRowVersionNumber
        {
            get
            {
                return this._SysRowVersionNumber;
            }
            set
            {
                this.OnSysRowVersionNumberChanging(value);
                this._SysRowVersionNumber = value;
                this.OnSysRowVersionNumberChanged();
                this.OnPropertyChanged("SysRowVersionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SysRowVersionNumber;
        partial void OnSysRowVersionNumberChanging(long value);
        partial void OnSysRowVersionNumberChanged();
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
