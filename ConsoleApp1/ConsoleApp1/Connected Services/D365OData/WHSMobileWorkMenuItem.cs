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
    /// There are no comments for WHSMobileWorkMenuItemSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WHSMobileWorkMenuItemSingle")]
    public partial class WHSMobileWorkMenuItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WHSMobileWorkMenuItem>
    {
        /// <summary>
        /// Initialize a new WHSMobileWorkMenuItemSingle object.
        /// </summary>
        public WHSMobileWorkMenuItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WHSMobileWorkMenuItemSingle object.
        /// </summary>
        public WHSMobileWorkMenuItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WHSMobileWorkMenuItemSingle object.
        /// </summary>
        public WHSMobileWorkMenuItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WHSMobileWorkMenuItem> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Menu in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Menu")]
        public virtual global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuSingle Menu
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Menu == null))
                {
                    this._Menu = new global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuSingle(this.Context, GetPath("Menu"));
                }
                return this._Menu;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenuSingle _Menu;
    }
    /// <summary>
    /// There are no comments for WHSMobileWorkMenuItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RecordId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RecordId")]
    [global::Microsoft.OData.Client.EntitySet("WHSMobileWorkMenuItems")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WHSMobileWorkMenuItem")]
    public partial class WHSMobileWorkMenuItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WHSMobileWorkMenuItem object.
        /// </summary>
        /// <param name="recordId">Initial value of RecordId.</param>
        /// <param name="menuRecId">Initial value of MenuRecId.</param>
        /// <param name="menu">Initial value of Menu.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WHSMobileWorkMenuItem CreateWHSMobileWorkMenuItem(long recordId, long menuRecId, global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenu menu)
        {
            WHSMobileWorkMenuItem wHSMobileWorkMenuItem = new WHSMobileWorkMenuItem();
            wHSMobileWorkMenuItem.RecordId = recordId;
            wHSMobileWorkMenuItem.MenuRecId = menuRecId;
            if ((menu == null))
            {
                throw new global::System.ArgumentNullException("menu");
            }
            wHSMobileWorkMenuItem.Menu = menu;
            return wHSMobileWorkMenuItem;
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
        /// There are no comments for Property MenuRecId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuRecId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MenuRecId is required.")]
        public virtual long MenuRecId
        {
            get
            {
                return this._MenuRecId;
            }
            set
            {
                this.OnMenuRecIdChanging(value);
                this._MenuRecId = value;
                this.OnMenuRecIdChanged();
                this.OnPropertyChanged("MenuRecId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _MenuRecId;
        partial void OnMenuRecIdChanging(long value);
        partial void OnMenuRecIdChanged();
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
        /// There are no comments for Property Menu in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Menu")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Menu is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenu Menu
        {
            get
            {
                return this._Menu;
            }
            set
            {
                this.OnMenuChanging(value);
                this._Menu = value;
                this.OnMenuChanged();
                this.OnPropertyChanged("Menu");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenu _Menu;
        partial void OnMenuChanging(global::Microsoft.Dynamics.DataEntities.WHSMobileWorkMenu value);
        partial void OnMenuChanged();
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
