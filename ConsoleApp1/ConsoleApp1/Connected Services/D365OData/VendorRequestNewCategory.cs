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
    /// There are no comments for VendorRequestNewCategorySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRequestNewCategorySingle")]
    public partial class VendorRequestNewCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRequestNewCategory>
    {
        /// <summary>
        /// Initialize a new VendorRequestNewCategorySingle object.
        /// </summary>
        public VendorRequestNewCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorRequestNewCategorySingle object.
        /// </summary>
        public VendorRequestNewCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorRequestNewCategorySingle object.
        /// </summary>
        public VendorRequestNewCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRequestNewCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RequestNewCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestNewCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RequestNewCategory> RequestNewCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RequestNewCategory == null))
                {
                    this._RequestNewCategory = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RequestNewCategory>(GetPath("RequestNewCategory"));
                }
                return this._RequestNewCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RequestNewCategory> _RequestNewCategory;
    }
    /// <summary>
    /// There are no comments for VendorRequestNewCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RequestId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RequestId")]
    [global::Microsoft.OData.Client.EntitySet("VendorRequestNewCategories")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRequestNewCategory")]
    public partial class VendorRequestNewCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorRequestNewCategory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="requestId">Initial value of RequestId.</param>
        /// <param name="instanceRelationType">Initial value of InstanceRelationType.</param>
        /// <param name="dateSubmitted">Initial value of DateSubmitted.</param>
        /// <param name="dateResolved">Initial value of DateResolved.</param>
        /// <param name="completedDateTime">Initial value of CompletedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorRequestNewCategory CreateVendorRequestNewCategory(string dataAreaId, 
                    string requestId, 
                    long instanceRelationType, 
                    global::System.DateTimeOffset dateSubmitted, 
                    global::System.DateTimeOffset dateResolved, 
                    global::System.DateTimeOffset completedDateTime)
        {
            VendorRequestNewCategory vendorRequestNewCategory = new VendorRequestNewCategory();
            vendorRequestNewCategory.DataAreaId = dataAreaId;
            vendorRequestNewCategory.RequestId = requestId;
            vendorRequestNewCategory.InstanceRelationType = instanceRelationType;
            vendorRequestNewCategory.DateSubmitted = dateSubmitted;
            vendorRequestNewCategory.DateResolved = dateResolved;
            vendorRequestNewCategory.CompletedDateTime = completedDateTime;
            return vendorRequestNewCategory;
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
        /// There are no comments for Property RequestId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RequestId is required.")]
        public virtual string RequestId
        {
            get
            {
                return this._RequestId;
            }
            set
            {
                this.OnRequestIdChanging(value);
                this._RequestId = value;
                this.OnRequestIdChanged();
                this.OnPropertyChanged("RequestId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestId;
        partial void OnRequestIdChanging(string value);
        partial void OnRequestIdChanged();
        /// <summary>
        /// There are no comments for Property VendorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorName")]
        public virtual string VendorName
        {
            get
            {
                return this._VendorName;
            }
            set
            {
                this.OnVendorNameChanging(value);
                this._VendorName = value;
                this.OnVendorNameChanged();
                this.OnPropertyChanged("VendorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorName;
        partial void OnVendorNameChanging(string value);
        partial void OnVendorNameChanged();
        /// <summary>
        /// There are no comments for Property InstanceRelationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InstanceRelationType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InstanceRelationType is required.")]
        public virtual long InstanceRelationType
        {
            get
            {
                return this._InstanceRelationType;
            }
            set
            {
                this.OnInstanceRelationTypeChanging(value);
                this._InstanceRelationType = value;
                this.OnInstanceRelationTypeChanged();
                this.OnPropertyChanged("InstanceRelationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _InstanceRelationType;
        partial void OnInstanceRelationTypeChanging(long value);
        partial void OnInstanceRelationTypeChanged();
        /// <summary>
        /// There are no comments for Property VendRequestOriginType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendRequestOriginType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestNewCategoryOriginType> VendRequestOriginType
        {
            get
            {
                return this._VendRequestOriginType;
            }
            set
            {
                this.OnVendRequestOriginTypeChanging(value);
                this._VendRequestOriginType = value;
                this.OnVendRequestOriginTypeChanged();
                this.OnPropertyChanged("VendRequestOriginType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestNewCategoryOriginType> _VendRequestOriginType;
        partial void OnVendRequestOriginTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestNewCategoryOriginType> value);
        partial void OnVendRequestOriginTypeChanged();
        /// <summary>
        /// There are no comments for Property VendorPortalAccessAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPortalAccessAllowed")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> VendorPortalAccessAllowed
        {
            get
            {
                return this._VendorPortalAccessAllowed;
            }
            set
            {
                this.OnVendorPortalAccessAllowedChanging(value);
                this._VendorPortalAccessAllowed = value;
                this.OnVendorPortalAccessAllowedChanged();
                this.OnPropertyChanged("VendorPortalAccessAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _VendorPortalAccessAllowed;
        partial void OnVendorPortalAccessAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnVendorPortalAccessAllowedChanged();
        /// <summary>
        /// There are no comments for Property AccountNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountNum")]
        public virtual string AccountNum
        {
            get
            {
                return this._AccountNum;
            }
            set
            {
                this.OnAccountNumChanging(value);
                this._AccountNum = value;
                this.OnAccountNumChanged();
                this.OnPropertyChanged("AccountNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNum;
        partial void OnAccountNumChanging(string value);
        partial void OnAccountNumChanged();
        /// <summary>
        /// There are no comments for Property DateSubmitted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateSubmitted")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateSubmitted is required.")]
        public virtual global::System.DateTimeOffset DateSubmitted
        {
            get
            {
                return this._DateSubmitted;
            }
            set
            {
                this.OnDateSubmittedChanging(value);
                this._DateSubmitted = value;
                this.OnDateSubmittedChanged();
                this.OnPropertyChanged("DateSubmitted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateSubmitted;
        partial void OnDateSubmittedChanging(global::System.DateTimeOffset value);
        partial void OnDateSubmittedChanged();
        /// <summary>
        /// There are no comments for Property DateResolved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateResolved")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DateResolved is required.")]
        public virtual global::System.DateTimeOffset DateResolved
        {
            get
            {
                return this._DateResolved;
            }
            set
            {
                this.OnDateResolvedChanging(value);
                this._DateResolved = value;
                this.OnDateResolvedChanged();
                this.OnPropertyChanged("DateResolved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateResolved;
        partial void OnDateResolvedChanging(global::System.DateTimeOffset value);
        partial void OnDateResolvedChanged();
        /// <summary>
        /// There are no comments for Property RequestStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestStatus")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestStatus> RequestStatus
        {
            get
            {
                return this._RequestStatus;
            }
            set
            {
                this.OnRequestStatusChanging(value);
                this._RequestStatus = value;
                this.OnRequestStatusChanged();
                this.OnPropertyChanged("RequestStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestStatus> _RequestStatus;
        partial void OnRequestStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestStatus> value);
        partial void OnRequestStatusChanged();
        /// <summary>
        /// There are no comments for Property SponsoredBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SponsoredBy")]
        public virtual string SponsoredBy
        {
            get
            {
                return this._SponsoredBy;
            }
            set
            {
                this.OnSponsoredByChanging(value);
                this._SponsoredBy = value;
                this.OnSponsoredByChanged();
                this.OnPropertyChanged("SponsoredBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SponsoredBy;
        partial void OnSponsoredByChanging(string value);
        partial void OnSponsoredByChanged();
        /// <summary>
        /// There are no comments for Property CompletedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompletedDateTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompletedDateTime is required.")]
        public virtual global::System.DateTimeOffset CompletedDateTime
        {
            get
            {
                return this._CompletedDateTime;
            }
            set
            {
                this.OnCompletedDateTimeChanging(value);
                this._CompletedDateTime = value;
                this.OnCompletedDateTimeChanged();
                this.OnPropertyChanged("CompletedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CompletedDateTime;
        partial void OnCompletedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnCompletedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property RequestEntityType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestEntityType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestEntityType> RequestEntityType
        {
            get
            {
                return this._RequestEntityType;
            }
            set
            {
                this.OnRequestEntityTypeChanging(value);
                this._RequestEntityType = value;
                this.OnRequestEntityTypeChanged();
                this.OnPropertyChanged("RequestEntityType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestEntityType> _RequestEntityType;
        partial void OnRequestEntityTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendVendorRequestEntityType> value);
        partial void OnRequestEntityTypeChanged();
        /// <summary>
        /// There are no comments for Property VendRequestWorkflowState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendRequestWorkflowState")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendRequestWorkflowState> VendRequestWorkflowState
        {
            get
            {
                return this._VendRequestWorkflowState;
            }
            set
            {
                this.OnVendRequestWorkflowStateChanging(value);
                this._VendRequestWorkflowState = value;
                this.OnVendRequestWorkflowStateChanged();
                this.OnPropertyChanged("VendRequestWorkflowState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendRequestWorkflowState> _VendRequestWorkflowState;
        partial void OnVendRequestWorkflowStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendRequestWorkflowState> value);
        partial void OnVendRequestWorkflowStateChanged();
        /// <summary>
        /// There are no comments for Property RequestNewCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestNewCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RequestNewCategory> RequestNewCategory
        {
            get
            {
                return this._RequestNewCategory;
            }
            set
            {
                this.OnRequestNewCategoryChanging(value);
                this._RequestNewCategory = value;
                this.OnRequestNewCategoryChanged();
                this.OnPropertyChanged("RequestNewCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RequestNewCategory> _RequestNewCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RequestNewCategory>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRequestNewCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RequestNewCategory> value);
        partial void OnRequestNewCategoryChanged();
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