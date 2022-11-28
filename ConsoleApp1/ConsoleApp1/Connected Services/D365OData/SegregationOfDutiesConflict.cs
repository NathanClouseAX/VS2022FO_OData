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
    /// There are no comments for SegregationOfDutiesConflictSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SegregationOfDutiesConflictSingle")]
    public partial class SegregationOfDutiesConflictSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SegregationOfDutiesConflict>
    {
        /// <summary>
        /// Initialize a new SegregationOfDutiesConflictSingle object.
        /// </summary>
        public SegregationOfDutiesConflictSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SegregationOfDutiesConflictSingle object.
        /// </summary>
        public SegregationOfDutiesConflictSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SegregationOfDutiesConflictSingle object.
        /// </summary>
        public SegregationOfDutiesConflictSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SegregationOfDutiesConflict> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SegregationOfDutiesConflict in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SegregationOfDutiesRuleValidFrom
    /// SegregationOfDutiesRuleValidTo
    /// SegregationOfDutiesRuleName
    /// User
    /// ExistingRoleIdentifier
    /// ExistingDutyIdentifier
    /// NewRoleIdentifier
    /// NewDutyIdentifier
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("SegregationOfDutiesRuleValidFrom", "SegregationOfDutiesRuleValidTo", "SegregationOfDutiesRuleName", "User", "ExistingRoleIdentifier", "ExistingDutyIdentifier", "NewRoleIdentifier", "NewDutyIdentifier")]
    [global::Microsoft.OData.Client.EntitySet("SegregationOfDutiesConflicts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SegregationOfDutiesConflict")]
    public partial class SegregationOfDutiesConflict : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SegregationOfDutiesConflict object.
        /// </summary>
        /// <param name="segregationOfDutiesRuleValidFrom">Initial value of SegregationOfDutiesRuleValidFrom.</param>
        /// <param name="segregationOfDutiesRuleValidTo">Initial value of SegregationOfDutiesRuleValidTo.</param>
        /// <param name="segregationOfDutiesRuleName">Initial value of SegregationOfDutiesRuleName.</param>
        /// <param name="user">Initial value of User.</param>
        /// <param name="existingRoleIdentifier">Initial value of ExistingRoleIdentifier.</param>
        /// <param name="existingDutyIdentifier">Initial value of ExistingDutyIdentifier.</param>
        /// <param name="newRoleIdentifier">Initial value of NewRoleIdentifier.</param>
        /// <param name="newDutyIdentifier">Initial value of NewDutyIdentifier.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SegregationOfDutiesConflict CreateSegregationOfDutiesConflict(global::System.DateTimeOffset segregationOfDutiesRuleValidFrom, 
                    global::System.DateTimeOffset segregationOfDutiesRuleValidTo, 
                    string segregationOfDutiesRuleName, 
                    string user, 
                    string existingRoleIdentifier, 
                    string existingDutyIdentifier, 
                    string newRoleIdentifier, 
                    string newDutyIdentifier)
        {
            SegregationOfDutiesConflict segregationOfDutiesConflict = new SegregationOfDutiesConflict();
            segregationOfDutiesConflict.SegregationOfDutiesRuleValidFrom = segregationOfDutiesRuleValidFrom;
            segregationOfDutiesConflict.SegregationOfDutiesRuleValidTo = segregationOfDutiesRuleValidTo;
            segregationOfDutiesConflict.SegregationOfDutiesRuleName = segregationOfDutiesRuleName;
            segregationOfDutiesConflict.User = user;
            segregationOfDutiesConflict.ExistingRoleIdentifier = existingRoleIdentifier;
            segregationOfDutiesConflict.ExistingDutyIdentifier = existingDutyIdentifier;
            segregationOfDutiesConflict.NewRoleIdentifier = newRoleIdentifier;
            segregationOfDutiesConflict.NewDutyIdentifier = newDutyIdentifier;
            return segregationOfDutiesConflict;
        }
        /// <summary>
        /// There are no comments for Property SegregationOfDutiesRuleValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegregationOfDutiesRuleValidFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SegregationOfDutiesRuleValidFrom is required.")]
        public virtual global::System.DateTimeOffset SegregationOfDutiesRuleValidFrom
        {
            get
            {
                return this._SegregationOfDutiesRuleValidFrom;
            }
            set
            {
                this.OnSegregationOfDutiesRuleValidFromChanging(value);
                this._SegregationOfDutiesRuleValidFrom = value;
                this.OnSegregationOfDutiesRuleValidFromChanged();
                this.OnPropertyChanged("SegregationOfDutiesRuleValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SegregationOfDutiesRuleValidFrom;
        partial void OnSegregationOfDutiesRuleValidFromChanging(global::System.DateTimeOffset value);
        partial void OnSegregationOfDutiesRuleValidFromChanged();
        /// <summary>
        /// There are no comments for Property SegregationOfDutiesRuleValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegregationOfDutiesRuleValidTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SegregationOfDutiesRuleValidTo is required.")]
        public virtual global::System.DateTimeOffset SegregationOfDutiesRuleValidTo
        {
            get
            {
                return this._SegregationOfDutiesRuleValidTo;
            }
            set
            {
                this.OnSegregationOfDutiesRuleValidToChanging(value);
                this._SegregationOfDutiesRuleValidTo = value;
                this.OnSegregationOfDutiesRuleValidToChanged();
                this.OnPropertyChanged("SegregationOfDutiesRuleValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SegregationOfDutiesRuleValidTo;
        partial void OnSegregationOfDutiesRuleValidToChanging(global::System.DateTimeOffset value);
        partial void OnSegregationOfDutiesRuleValidToChanged();
        /// <summary>
        /// There are no comments for Property SegregationOfDutiesRuleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegregationOfDutiesRuleName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SegregationOfDutiesRuleName is required.")]
        public virtual string SegregationOfDutiesRuleName
        {
            get
            {
                return this._SegregationOfDutiesRuleName;
            }
            set
            {
                this.OnSegregationOfDutiesRuleNameChanging(value);
                this._SegregationOfDutiesRuleName = value;
                this.OnSegregationOfDutiesRuleNameChanged();
                this.OnPropertyChanged("SegregationOfDutiesRuleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegregationOfDutiesRuleName;
        partial void OnSegregationOfDutiesRuleNameChanging(string value);
        partial void OnSegregationOfDutiesRuleNameChanged();
        /// <summary>
        /// There are no comments for Property User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "User is required.")]
        public virtual string User
        {
            get
            {
                return this._User;
            }
            set
            {
                this.OnUserChanging(value);
                this._User = value;
                this.OnUserChanged();
                this.OnPropertyChanged("User");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _User;
        partial void OnUserChanging(string value);
        partial void OnUserChanged();
        /// <summary>
        /// There are no comments for Property ExistingRoleIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExistingRoleIdentifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExistingRoleIdentifier is required.")]
        public virtual string ExistingRoleIdentifier
        {
            get
            {
                return this._ExistingRoleIdentifier;
            }
            set
            {
                this.OnExistingRoleIdentifierChanging(value);
                this._ExistingRoleIdentifier = value;
                this.OnExistingRoleIdentifierChanged();
                this.OnPropertyChanged("ExistingRoleIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExistingRoleIdentifier;
        partial void OnExistingRoleIdentifierChanging(string value);
        partial void OnExistingRoleIdentifierChanged();
        /// <summary>
        /// There are no comments for Property ExistingDutyIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExistingDutyIdentifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ExistingDutyIdentifier is required.")]
        public virtual string ExistingDutyIdentifier
        {
            get
            {
                return this._ExistingDutyIdentifier;
            }
            set
            {
                this.OnExistingDutyIdentifierChanging(value);
                this._ExistingDutyIdentifier = value;
                this.OnExistingDutyIdentifierChanged();
                this.OnPropertyChanged("ExistingDutyIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExistingDutyIdentifier;
        partial void OnExistingDutyIdentifierChanging(string value);
        partial void OnExistingDutyIdentifierChanged();
        /// <summary>
        /// There are no comments for Property NewRoleIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NewRoleIdentifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NewRoleIdentifier is required.")]
        public virtual string NewRoleIdentifier
        {
            get
            {
                return this._NewRoleIdentifier;
            }
            set
            {
                this.OnNewRoleIdentifierChanging(value);
                this._NewRoleIdentifier = value;
                this.OnNewRoleIdentifierChanged();
                this.OnPropertyChanged("NewRoleIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NewRoleIdentifier;
        partial void OnNewRoleIdentifierChanging(string value);
        partial void OnNewRoleIdentifierChanged();
        /// <summary>
        /// There are no comments for Property NewDutyIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NewDutyIdentifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NewDutyIdentifier is required.")]
        public virtual string NewDutyIdentifier
        {
            get
            {
                return this._NewDutyIdentifier;
            }
            set
            {
                this.OnNewDutyIdentifierChanging(value);
                this._NewDutyIdentifier = value;
                this.OnNewDutyIdentifierChanged();
                this.OnPropertyChanged("NewDutyIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NewDutyIdentifier;
        partial void OnNewDutyIdentifierChanging(string value);
        partial void OnNewDutyIdentifierChanged();
        /// <summary>
        /// There are no comments for Property ExistingDutyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExistingDutyName")]
        public virtual string ExistingDutyName
        {
            get
            {
                return this._ExistingDutyName;
            }
            set
            {
                this.OnExistingDutyNameChanging(value);
                this._ExistingDutyName = value;
                this.OnExistingDutyNameChanged();
                this.OnPropertyChanged("ExistingDutyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExistingDutyName;
        partial void OnExistingDutyNameChanging(string value);
        partial void OnExistingDutyNameChanged();
        /// <summary>
        /// There are no comments for Property NewDutyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NewDutyName")]
        public virtual string NewDutyName
        {
            get
            {
                return this._NewDutyName;
            }
            set
            {
                this.OnNewDutyNameChanging(value);
                this._NewDutyName = value;
                this.OnNewDutyNameChanged();
                this.OnPropertyChanged("NewDutyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NewDutyName;
        partial void OnNewDutyNameChanging(string value);
        partial void OnNewDutyNameChanged();
        /// <summary>
        /// There are no comments for Property NewRoleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NewRoleName")]
        public virtual string NewRoleName
        {
            get
            {
                return this._NewRoleName;
            }
            set
            {
                this.OnNewRoleNameChanging(value);
                this._NewRoleName = value;
                this.OnNewRoleNameChanged();
                this.OnPropertyChanged("NewRoleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NewRoleName;
        partial void OnNewRoleNameChanging(string value);
        partial void OnNewRoleNameChanged();
        /// <summary>
        /// There are no comments for Property ReasonForOverride in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonForOverride")]
        public virtual string ReasonForOverride
        {
            get
            {
                return this._ReasonForOverride;
            }
            set
            {
                this.OnReasonForOverrideChanging(value);
                this._ReasonForOverride = value;
                this.OnReasonForOverrideChanged();
                this.OnPropertyChanged("ReasonForOverride");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonForOverride;
        partial void OnReasonForOverrideChanging(string value);
        partial void OnReasonForOverrideChanged();
        /// <summary>
        /// There are no comments for Property AssignmentMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignmentMode")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RoleAssignmentMode> AssignmentMode
        {
            get
            {
                return this._AssignmentMode;
            }
            set
            {
                this.OnAssignmentModeChanging(value);
                this._AssignmentMode = value;
                this.OnAssignmentModeChanged();
                this.OnPropertyChanged("AssignmentMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RoleAssignmentMode> _AssignmentMode;
        partial void OnAssignmentModeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RoleAssignmentMode> value);
        partial void OnAssignmentModeChanged();
        /// <summary>
        /// There are no comments for Property ExistingRoleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExistingRoleName")]
        public virtual string ExistingRoleName
        {
            get
            {
                return this._ExistingRoleName;
            }
            set
            {
                this.OnExistingRoleNameChanging(value);
                this._ExistingRoleName = value;
                this.OnExistingRoleNameChanged();
                this.OnPropertyChanged("ExistingRoleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExistingRoleName;
        partial void OnExistingRoleNameChanging(string value);
        partial void OnExistingRoleNameChanged();
        /// <summary>
        /// There are no comments for Property Resolution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Resolution")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SegregationOfDutiesResolution> Resolution
        {
            get
            {
                return this._Resolution;
            }
            set
            {
                this.OnResolutionChanging(value);
                this._Resolution = value;
                this.OnResolutionChanged();
                this.OnPropertyChanged("Resolution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SegregationOfDutiesResolution> _Resolution;
        partial void OnResolutionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SegregationOfDutiesResolution> value);
        partial void OnResolutionChanged();
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
