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
    /// There are no comments for BIFormControlBindingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BIFormControlBindingSingle")]
    public partial class BIFormControlBindingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BIFormControlBinding>
    {
        /// <summary>
        /// Initialize a new BIFormControlBindingSingle object.
        /// </summary>
        public BIFormControlBindingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BIFormControlBindingSingle object.
        /// </summary>
        public BIFormControlBindingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BIFormControlBindingSingle object.
        /// </summary>
        public BIFormControlBindingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BIFormControlBinding> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BIFormControlBinding in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FormName
    /// UserId
    /// DashboardId
    /// ControlId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("formName", "userId", "dashboardId", "controlId")]
    [global::Microsoft.OData.Client.EntitySet("BIFormControlBindings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BIFormControlBinding")]
    public partial class BIFormControlBinding : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BIFormControlBinding object.
        /// </summary>
        /// <param name="formName">Initial value of FormName.</param>
        /// <param name="userId">Initial value of UserId.</param>
        /// <param name="dashboardId">Initial value of DashboardId.</param>
        /// <param name="controlId">Initial value of ControlId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BIFormControlBinding CreateBIFormControlBinding(string formName, string userId, global::System.Guid dashboardId, global::System.Guid controlId)
        {
            BIFormControlBinding bIFormControlBinding = new BIFormControlBinding();
            bIFormControlBinding.FormName = formName;
            bIFormControlBinding.UserId = userId;
            bIFormControlBinding.DashboardId = dashboardId;
            bIFormControlBinding.ControlId = controlId;
            return bIFormControlBinding;
        }
        /// <summary>
        /// There are no comments for Property FormName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("formName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FormName is required.")]
        public virtual string FormName
        {
            get
            {
                return this._FormName;
            }
            set
            {
                this.OnFormNameChanging(value);
                this._FormName = value;
                this.OnFormNameChanged();
                this.OnPropertyChanged("formName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FormName;
        partial void OnFormNameChanging(string value);
        partial void OnFormNameChanged();
        /// <summary>
        /// There are no comments for Property UserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("userId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UserId is required.")]
        public virtual string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this.OnUserIdChanging(value);
                this._UserId = value;
                this.OnUserIdChanged();
                this.OnPropertyChanged("userId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserId;
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        /// <summary>
        /// There are no comments for Property DashboardId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("dashboardId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DashboardId is required.")]
        public virtual global::System.Guid DashboardId
        {
            get
            {
                return this._DashboardId;
            }
            set
            {
                this.OnDashboardIdChanging(value);
                this._DashboardId = value;
                this.OnDashboardIdChanged();
                this.OnPropertyChanged("dashboardId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _DashboardId;
        partial void OnDashboardIdChanging(global::System.Guid value);
        partial void OnDashboardIdChanged();
        /// <summary>
        /// There are no comments for Property ControlId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("controlId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ControlId is required.")]
        public virtual global::System.Guid ControlId
        {
            get
            {
                return this._ControlId;
            }
            set
            {
                this.OnControlIdChanging(value);
                this._ControlId = value;
                this.OnControlIdChanged();
                this.OnPropertyChanged("controlId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ControlId;
        partial void OnControlIdChanging(global::System.Guid value);
        partial void OnControlIdChanged();
        /// <summary>
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("size")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PowerBIControlSize> Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("size");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PowerBIControlSize> _Size;
        partial void OnSizeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PowerBIControlSize> value);
        partial void OnSizeChanged();
        /// <summary>
        /// There are no comments for Property EmbedUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("embedUrl")]
        public virtual string EmbedUrl
        {
            get
            {
                return this._EmbedUrl;
            }
            set
            {
                this.OnEmbedUrlChanging(value);
                this._EmbedUrl = value;
                this.OnEmbedUrlChanged();
                this.OnPropertyChanged("embedUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmbedUrl;
        partial void OnEmbedUrlChanging(string value);
        partial void OnEmbedUrlChanged();
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