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
    /// There are no comments for StaffPermissionGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("StaffPermissionGroupSingle")]
    public partial class StaffPermissionGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<StaffPermissionGroup>
    {
        /// <summary>
        /// Initialize a new StaffPermissionGroupSingle object.
        /// </summary>
        public StaffPermissionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new StaffPermissionGroupSingle object.
        /// </summary>
        public StaffPermissionGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new StaffPermissionGroupSingle object.
        /// </summary>
        public StaffPermissionGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<StaffPermissionGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for StaffPermissionGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PermissionGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PermissionGroupId")]
    [global::Microsoft.OData.Client.EntitySet("StaffPermissionGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("StaffPermissionGroup")]
    public partial class StaffPermissionGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new StaffPermissionGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="permissionGroupId">Initial value of PermissionGroupId.</param>
        /// <param name="maxDiscountPercent">Initial value of MaxDiscountPercent.</param>
        /// <param name="maxTotalDiscountAmount">Initial value of MaxTotalDiscountAmount.</param>
        /// <param name="maxLineDiscountAmount">Initial value of MaxLineDiscountAmount.</param>
        /// <param name="maxTotalDiscountPercent">Initial value of MaxTotalDiscountPercent.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static StaffPermissionGroup CreateStaffPermissionGroup(string dataAreaId, 
                    string permissionGroupId, 
                    decimal maxDiscountPercent, 
                    decimal maxTotalDiscountAmount, 
                    decimal maxLineDiscountAmount, 
                    decimal maxTotalDiscountPercent)
        {
            StaffPermissionGroup staffPermissionGroup = new StaffPermissionGroup();
            staffPermissionGroup.DataAreaId = dataAreaId;
            staffPermissionGroup.PermissionGroupId = permissionGroupId;
            staffPermissionGroup.MaxDiscountPercent = maxDiscountPercent;
            staffPermissionGroup.MaxTotalDiscountAmount = maxTotalDiscountAmount;
            staffPermissionGroup.MaxLineDiscountAmount = maxLineDiscountAmount;
            staffPermissionGroup.MaxTotalDiscountPercent = maxTotalDiscountPercent;
            return staffPermissionGroup;
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
        /// There are no comments for Property PermissionGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PermissionGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PermissionGroupId is required.")]
        public virtual string PermissionGroupId
        {
            get
            {
                return this._PermissionGroupId;
            }
            set
            {
                this.OnPermissionGroupIdChanging(value);
                this._PermissionGroupId = value;
                this.OnPermissionGroupIdChanged();
                this.OnPropertyChanged("PermissionGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PermissionGroupId;
        partial void OnPermissionGroupIdChanging(string value);
        partial void OnPermissionGroupIdChanged();
        /// <summary>
        /// There are no comments for Property IsAllowOpenDrawerOnly in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowOpenDrawerOnly")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowOpenDrawerOnly
        {
            get
            {
                return this._IsAllowOpenDrawerOnly;
            }
            set
            {
                this.OnIsAllowOpenDrawerOnlyChanging(value);
                this._IsAllowOpenDrawerOnly = value;
                this.OnIsAllowOpenDrawerOnlyChanged();
                this.OnPropertyChanged("IsAllowOpenDrawerOnly");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowOpenDrawerOnly;
        partial void OnIsAllowOpenDrawerOnlyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowOpenDrawerOnlyChanged();
        /// <summary>
        /// There are no comments for Property MaxDiscountPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaxDiscountPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaxDiscountPercent is required.")]
        public virtual decimal MaxDiscountPercent
        {
            get
            {
                return this._MaxDiscountPercent;
            }
            set
            {
                this.OnMaxDiscountPercentChanging(value);
                this._MaxDiscountPercent = value;
                this.OnMaxDiscountPercentChanged();
                this.OnPropertyChanged("MaxDiscountPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaxDiscountPercent;
        partial void OnMaxDiscountPercentChanging(decimal value);
        partial void OnMaxDiscountPercentChanged();
        /// <summary>
        /// There are no comments for Property MaxTotalDiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaxTotalDiscountAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaxTotalDiscountAmount is required.")]
        public virtual decimal MaxTotalDiscountAmount
        {
            get
            {
                return this._MaxTotalDiscountAmount;
            }
            set
            {
                this.OnMaxTotalDiscountAmountChanging(value);
                this._MaxTotalDiscountAmount = value;
                this.OnMaxTotalDiscountAmountChanged();
                this.OnPropertyChanged("MaxTotalDiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaxTotalDiscountAmount;
        partial void OnMaxTotalDiscountAmountChanging(decimal value);
        partial void OnMaxTotalDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property IsAllowFloatingTenderDeclaration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowFloatingTenderDeclaration")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowFloatingTenderDeclaration
        {
            get
            {
                return this._IsAllowFloatingTenderDeclaration;
            }
            set
            {
                this.OnIsAllowFloatingTenderDeclarationChanging(value);
                this._IsAllowFloatingTenderDeclaration = value;
                this.OnIsAllowFloatingTenderDeclarationChanged();
                this.OnPropertyChanged("IsAllowFloatingTenderDeclaration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowFloatingTenderDeclaration;
        partial void OnIsAllowFloatingTenderDeclarationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowFloatingTenderDeclarationChanged();
        /// <summary>
        /// There are no comments for Property IsAllowZReportPrinting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowZReportPrinting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowZReportPrinting
        {
            get
            {
                return this._IsAllowZReportPrinting;
            }
            set
            {
                this.OnIsAllowZReportPrintingChanging(value);
                this._IsAllowZReportPrinting = value;
                this.OnIsAllowZReportPrintingChanged();
                this.OnPropertyChanged("IsAllowZReportPrinting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowZReportPrinting;
        partial void OnIsAllowZReportPrintingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowZReportPrintingChanged();
        /// <summary>
        /// There are no comments for Property IsAllowTransactionSuspension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowTransactionSuspension")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowTransactionSuspension
        {
            get
            {
                return this._IsAllowTransactionSuspension;
            }
            set
            {
                this.OnIsAllowTransactionSuspensionChanging(value);
                this._IsAllowTransactionSuspension = value;
                this.OnIsAllowTransactionSuspensionChanged();
                this.OnPropertyChanged("IsAllowTransactionSuspension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowTransactionSuspension;
        partial void OnIsAllowTransactionSuspensionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowTransactionSuspensionChanged();
        /// <summary>
        /// There are no comments for Property AllowPriceOverride in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowPriceOverride")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPriceOverride> AllowPriceOverride
        {
            get
            {
                return this._AllowPriceOverride;
            }
            set
            {
                this.OnAllowPriceOverrideChanging(value);
                this._AllowPriceOverride = value;
                this.OnAllowPriceOverrideChanged();
                this.OnPropertyChanged("AllowPriceOverride");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPriceOverride> _AllowPriceOverride;
        partial void OnAllowPriceOverrideChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailPriceOverride> value);
        partial void OnAllowPriceOverrideChanged();
        /// <summary>
        /// There are no comments for Property MaxLineDiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaxLineDiscountAmount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaxLineDiscountAmount is required.")]
        public virtual decimal MaxLineDiscountAmount
        {
            get
            {
                return this._MaxLineDiscountAmount;
            }
            set
            {
                this.OnMaxLineDiscountAmountChanging(value);
                this._MaxLineDiscountAmount = value;
                this.OnMaxLineDiscountAmountChanged();
                this.OnPropertyChanged("MaxLineDiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaxLineDiscountAmount;
        partial void OnMaxLineDiscountAmountChanging(decimal value);
        partial void OnMaxLineDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property IsAllowTransactionVoiding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowTransactionVoiding")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowTransactionVoiding
        {
            get
            {
                return this._IsAllowTransactionVoiding;
            }
            set
            {
                this.OnIsAllowTransactionVoidingChanging(value);
                this._IsAllowTransactionVoiding = value;
                this.OnIsAllowTransactionVoidingChanged();
                this.OnPropertyChanged("IsAllowTransactionVoiding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowTransactionVoiding;
        partial void OnIsAllowTransactionVoidingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowTransactionVoidingChanged();
        /// <summary>
        /// There are no comments for Property PermissionGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PermissionGroupName")]
        public virtual string PermissionGroupName
        {
            get
            {
                return this._PermissionGroupName;
            }
            set
            {
                this.OnPermissionGroupNameChanging(value);
                this._PermissionGroupName = value;
                this.OnPermissionGroupNameChanged();
                this.OnPropertyChanged("PermissionGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PermissionGroupName;
        partial void OnPermissionGroupNameChanging(string value);
        partial void OnPermissionGroupNameChanged();
        /// <summary>
        /// There are no comments for Property MaxTotalDiscountPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaxTotalDiscountPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaxTotalDiscountPercent is required.")]
        public virtual decimal MaxTotalDiscountPercent
        {
            get
            {
                return this._MaxTotalDiscountPercent;
            }
            set
            {
                this.OnMaxTotalDiscountPercentChanging(value);
                this._MaxTotalDiscountPercent = value;
                this.OnMaxTotalDiscountPercentChanged();
                this.OnPropertyChanged("MaxTotalDiscountPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaxTotalDiscountPercent;
        partial void OnMaxTotalDiscountPercentChanging(decimal value);
        partial void OnMaxTotalDiscountPercentChanged();
        /// <summary>
        /// There are no comments for Property IsManagerPrivileges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsManagerPrivileges")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsManagerPrivileges
        {
            get
            {
                return this._IsManagerPrivileges;
            }
            set
            {
                this.OnIsManagerPrivilegesChanging(value);
                this._IsManagerPrivileges = value;
                this.OnIsManagerPrivilegesChanged();
                this.OnPropertyChanged("IsManagerPrivileges");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsManagerPrivileges;
        partial void OnIsManagerPrivilegesChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsManagerPrivilegesChanged();
        /// <summary>
        /// There are no comments for Property IsAllowTenderDeclaration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowTenderDeclaration")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowTenderDeclaration
        {
            get
            {
                return this._IsAllowTenderDeclaration;
            }
            set
            {
                this.OnIsAllowTenderDeclarationChanging(value);
                this._IsAllowTenderDeclaration = value;
                this.OnIsAllowTenderDeclarationChanged();
                this.OnPropertyChanged("IsAllowTenderDeclaration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowTenderDeclaration;
        partial void OnIsAllowTenderDeclarationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowTenderDeclarationChanged();
        /// <summary>
        /// There are no comments for Property IsAllowXReportPrinting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowXReportPrinting")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowXReportPrinting
        {
            get
            {
                return this._IsAllowXReportPrinting;
            }
            set
            {
                this.OnIsAllowXReportPrintingChanging(value);
                this._IsAllowXReportPrinting = value;
                this.OnIsAllowXReportPrintingChanged();
                this.OnPropertyChanged("IsAllowXReportPrinting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowXReportPrinting;
        partial void OnIsAllowXReportPrintingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowXReportPrintingChanged();
        /// <summary>
        /// There are no comments for Property IsAllowChangeNoVoid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAllowChangeNoVoid")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAllowChangeNoVoid
        {
            get
            {
                return this._IsAllowChangeNoVoid;
            }
            set
            {
                this.OnIsAllowChangeNoVoidChanging(value);
                this._IsAllowChangeNoVoid = value;
                this.OnIsAllowChangeNoVoidChanged();
                this.OnPropertyChanged("IsAllowChangeNoVoid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAllowChangeNoVoid;
        partial void OnIsAllowChangeNoVoidChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAllowChangeNoVoidChanged();
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
