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
    /// There are no comments for LeaveTypeSuspensionRelationshipSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveTypeSuspensionRelationshipSingle")]
    public partial class LeaveTypeSuspensionRelationshipSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaveTypeSuspensionRelationship>
    {
        /// <summary>
        /// Initialize a new LeaveTypeSuspensionRelationshipSingle object.
        /// </summary>
        public LeaveTypeSuspensionRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaveTypeSuspensionRelationshipSingle object.
        /// </summary>
        public LeaveTypeSuspensionRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaveTypeSuspensionRelationshipSingle object.
        /// </summary>
        public LeaveTypeSuspensionRelationshipSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaveTypeSuspensionRelationship> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SuspendedByLeaveType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SuspendedByLeaveType")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveTypeSingle SuspendedByLeaveType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SuspendedByLeaveType == null))
                {
                    this._SuspendedByLeaveType = new global::Microsoft.Dynamics.DataEntities.LeaveTypeSingle(this.Context, GetPath("SuspendedByLeaveType"));
                }
                return this._SuspendedByLeaveType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveTypeSingle _SuspendedByLeaveType;
        /// <summary>
        /// There are no comments for SuspendedLeaveType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SuspendedLeaveType")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveTypeSingle SuspendedLeaveType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SuspendedLeaveType == null))
                {
                    this._SuspendedLeaveType = new global::Microsoft.Dynamics.DataEntities.LeaveTypeSingle(this.Context, GetPath("SuspendedLeaveType"));
                }
                return this._SuspendedLeaveType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveTypeSingle _SuspendedLeaveType;
    }
    /// <summary>
    /// There are no comments for LeaveTypeSuspensionRelationship in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// SuspendedByLeaveType_Type
    /// SuspendedLeaveType_Type
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SuspendedByLeaveType_Type", "SuspendedLeaveType_Type")]
    [global::Microsoft.OData.Client.EntitySet("LeaveTypeSuspensionRelationships")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveTypeSuspensionRelationship")]
    public partial class LeaveTypeSuspensionRelationship : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaveTypeSuspensionRelationship object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="suspendedByLeaveType_Type">Initial value of SuspendedByLeaveType_Type.</param>
        /// <param name="suspendedLeaveType_Type">Initial value of SuspendedLeaveType_Type.</param>
        /// <param name="suspendedByLeaveType">Initial value of SuspendedByLeaveType.</param>
        /// <param name="suspendedLeaveType">Initial value of SuspendedLeaveType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaveTypeSuspensionRelationship CreateLeaveTypeSuspensionRelationship(string dataAreaId, string suspendedByLeaveType_Type, string suspendedLeaveType_Type, global::Microsoft.Dynamics.DataEntities.LeaveType suspendedByLeaveType, global::Microsoft.Dynamics.DataEntities.LeaveType suspendedLeaveType)
        {
            LeaveTypeSuspensionRelationship leaveTypeSuspensionRelationship = new LeaveTypeSuspensionRelationship();
            leaveTypeSuspensionRelationship.DataAreaId = dataAreaId;
            leaveTypeSuspensionRelationship.SuspendedByLeaveType_Type = suspendedByLeaveType_Type;
            leaveTypeSuspensionRelationship.SuspendedLeaveType_Type = suspendedLeaveType_Type;
            if ((suspendedByLeaveType == null))
            {
                throw new global::System.ArgumentNullException("suspendedByLeaveType");
            }
            leaveTypeSuspensionRelationship.SuspendedByLeaveType = suspendedByLeaveType;
            if ((suspendedLeaveType == null))
            {
                throw new global::System.ArgumentNullException("suspendedLeaveType");
            }
            leaveTypeSuspensionRelationship.SuspendedLeaveType = suspendedLeaveType;
            return leaveTypeSuspensionRelationship;
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
        /// There are no comments for Property SuspendedByLeaveType_Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SuspendedByLeaveType_Type")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SuspendedByLeaveType_Type is required.")]
        public virtual string SuspendedByLeaveType_Type
        {
            get
            {
                return this._SuspendedByLeaveType_Type;
            }
            set
            {
                this.OnSuspendedByLeaveType_TypeChanging(value);
                this._SuspendedByLeaveType_Type = value;
                this.OnSuspendedByLeaveType_TypeChanged();
                this.OnPropertyChanged("SuspendedByLeaveType_Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SuspendedByLeaveType_Type;
        partial void OnSuspendedByLeaveType_TypeChanging(string value);
        partial void OnSuspendedByLeaveType_TypeChanged();
        /// <summary>
        /// There are no comments for Property SuspendedLeaveType_Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SuspendedLeaveType_Type")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SuspendedLeaveType_Type is required.")]
        public virtual string SuspendedLeaveType_Type
        {
            get
            {
                return this._SuspendedLeaveType_Type;
            }
            set
            {
                this.OnSuspendedLeaveType_TypeChanging(value);
                this._SuspendedLeaveType_Type = value;
                this.OnSuspendedLeaveType_TypeChanged();
                this.OnPropertyChanged("SuspendedLeaveType_Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SuspendedLeaveType_Type;
        partial void OnSuspendedLeaveType_TypeChanging(string value);
        partial void OnSuspendedLeaveType_TypeChanged();
        /// <summary>
        /// There are no comments for Property SuspendedByLeaveType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SuspendedByLeaveType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SuspendedByLeaveType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveType SuspendedByLeaveType
        {
            get
            {
                return this._SuspendedByLeaveType;
            }
            set
            {
                this.OnSuspendedByLeaveTypeChanging(value);
                this._SuspendedByLeaveType = value;
                this.OnSuspendedByLeaveTypeChanged();
                this.OnPropertyChanged("SuspendedByLeaveType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveType _SuspendedByLeaveType;
        partial void OnSuspendedByLeaveTypeChanging(global::Microsoft.Dynamics.DataEntities.LeaveType value);
        partial void OnSuspendedByLeaveTypeChanged();
        /// <summary>
        /// There are no comments for Property SuspendedLeaveType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SuspendedLeaveType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SuspendedLeaveType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveType SuspendedLeaveType
        {
            get
            {
                return this._SuspendedLeaveType;
            }
            set
            {
                this.OnSuspendedLeaveTypeChanging(value);
                this._SuspendedLeaveType = value;
                this.OnSuspendedLeaveTypeChanged();
                this.OnPropertyChanged("SuspendedLeaveType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveType _SuspendedLeaveType;
        partial void OnSuspendedLeaveTypeChanging(global::Microsoft.Dynamics.DataEntities.LeaveType value);
        partial void OnSuspendedLeaveTypeChanged();
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
