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
    /// There are no comments for PersonnelActionTypeSetupRoleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelActionTypeSetupRoleSingle")]
    public partial class PersonnelActionTypeSetupRoleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonnelActionTypeSetupRole>
    {
        /// <summary>
        /// Initialize a new PersonnelActionTypeSetupRoleSingle object.
        /// </summary>
        public PersonnelActionTypeSetupRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonnelActionTypeSetupRoleSingle object.
        /// </summary>
        public PersonnelActionTypeSetupRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonnelActionTypeSetupRoleSingle object.
        /// </summary>
        public PersonnelActionTypeSetupRoleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonnelActionTypeSetupRole> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PersonnelActionTypeSetupRole in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelActionTypeId
    /// RoleName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelActionTypeId", "RoleName")]
    [global::Microsoft.OData.Client.EntitySet("PersonnelActionTypeSetupRoles")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelActionTypeSetupRole")]
    public partial class PersonnelActionTypeSetupRole : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonnelActionTypeSetupRole object.
        /// </summary>
        /// <param name="personnelActionTypeId">Initial value of PersonnelActionTypeId.</param>
        /// <param name="roleName">Initial value of RoleName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonnelActionTypeSetupRole CreatePersonnelActionTypeSetupRole(string personnelActionTypeId, string roleName)
        {
            PersonnelActionTypeSetupRole personnelActionTypeSetupRole = new PersonnelActionTypeSetupRole();
            personnelActionTypeSetupRole.PersonnelActionTypeId = personnelActionTypeId;
            personnelActionTypeSetupRole.RoleName = roleName;
            return personnelActionTypeSetupRole;
        }
        /// <summary>
        /// There are no comments for Property PersonnelActionTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelActionTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PersonnelActionTypeId is required.")]
        public virtual string PersonnelActionTypeId
        {
            get
            {
                return this._PersonnelActionTypeId;
            }
            set
            {
                this.OnPersonnelActionTypeIdChanging(value);
                this._PersonnelActionTypeId = value;
                this.OnPersonnelActionTypeIdChanged();
                this.OnPropertyChanged("PersonnelActionTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelActionTypeId;
        partial void OnPersonnelActionTypeIdChanging(string value);
        partial void OnPersonnelActionTypeIdChanged();
        /// <summary>
        /// There are no comments for Property RoleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RoleName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RoleName is required.")]
        public virtual string RoleName
        {
            get
            {
                return this._RoleName;
            }
            set
            {
                this.OnRoleNameChanging(value);
                this._RoleName = value;
                this.OnRoleNameChanged();
                this.OnPropertyChanged("RoleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoleName;
        partial void OnRoleNameChanging(string value);
        partial void OnRoleNameChanged();
        /// <summary>
        /// There are no comments for Property CreateAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreateAction")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CreateAction
        {
            get
            {
                return this._CreateAction;
            }
            set
            {
                this.OnCreateActionChanging(value);
                this._CreateAction = value;
                this.OnCreateActionChanged();
                this.OnPropertyChanged("CreateAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CreateAction;
        partial void OnCreateActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCreateActionChanged();
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