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
    /// There are no comments for EMWebApplicationSecurityRoleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EMWebApplicationSecurityRoleSingle")]
    public partial class EMWebApplicationSecurityRoleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EMWebApplicationSecurityRole>
    {
        /// <summary>
        /// Initialize a new EMWebApplicationSecurityRoleSingle object.
        /// </summary>
        public EMWebApplicationSecurityRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EMWebApplicationSecurityRoleSingle object.
        /// </summary>
        public EMWebApplicationSecurityRoleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EMWebApplicationSecurityRoleSingle object.
        /// </summary>
        public EMWebApplicationSecurityRoleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EMWebApplicationSecurityRole> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EMWebApplicationSecurityRole in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// WebApplicationName
    /// SecurityRoleAotName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WebApplicationName", "SecurityRoleAotName")]
    [global::Microsoft.OData.Client.EntitySet("EMWebApplicationSecurityRoles")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EMWebApplicationSecurityRole")]
    public partial class EMWebApplicationSecurityRole : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EMWebApplicationSecurityRole object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="webApplicationName">Initial value of WebApplicationName.</param>
        /// <param name="securityRoleAotName">Initial value of SecurityRoleAotName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EMWebApplicationSecurityRole CreateEMWebApplicationSecurityRole(string dataAreaId, string webApplicationName, string securityRoleAotName)
        {
            EMWebApplicationSecurityRole eMWebApplicationSecurityRole = new EMWebApplicationSecurityRole();
            eMWebApplicationSecurityRole.DataAreaId = dataAreaId;
            eMWebApplicationSecurityRole.WebApplicationName = webApplicationName;
            eMWebApplicationSecurityRole.SecurityRoleAotName = securityRoleAotName;
            return eMWebApplicationSecurityRole;
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
        /// There are no comments for Property WebApplicationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebApplicationName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WebApplicationName is required.")]
        public virtual string WebApplicationName
        {
            get
            {
                return this._WebApplicationName;
            }
            set
            {
                this.OnWebApplicationNameChanging(value);
                this._WebApplicationName = value;
                this.OnWebApplicationNameChanged();
                this.OnPropertyChanged("WebApplicationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WebApplicationName;
        partial void OnWebApplicationNameChanging(string value);
        partial void OnWebApplicationNameChanged();
        /// <summary>
        /// There are no comments for Property SecurityRoleAotName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SecurityRoleAotName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SecurityRoleAotName is required.")]
        public virtual string SecurityRoleAotName
        {
            get
            {
                return this._SecurityRoleAotName;
            }
            set
            {
                this.OnSecurityRoleAotNameChanging(value);
                this._SecurityRoleAotName = value;
                this.OnSecurityRoleAotNameChanged();
                this.OnPropertyChanged("SecurityRoleAotName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SecurityRoleAotName;
        partial void OnSecurityRoleAotNameChanging(string value);
        partial void OnSecurityRoleAotNameChanged();
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
