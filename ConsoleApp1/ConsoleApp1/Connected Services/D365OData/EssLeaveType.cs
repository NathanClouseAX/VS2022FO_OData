//------------------------------------------------------------------------------
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
    /// There are no comments for EssLeaveTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EssLeaveTypeSingle")]
    public partial class EssLeaveTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EssLeaveType>
    {
        /// <summary>
        /// Initialize a new EssLeaveTypeSingle object.
        /// </summary>
        public EssLeaveTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EssLeaveTypeSingle object.
        /// </summary>
        public EssLeaveTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EssLeaveTypeSingle object.
        /// </summary>
        public EssLeaveTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EssLeaveType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReasonCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonCodes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode> ReasonCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReasonCodes == null))
                {
                    this._ReasonCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode>(GetPath("ReasonCodes"));
                }
                return this._ReasonCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode> _ReasonCodes;
        /// <summary>
        /// There are no comments for TimeOffDates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeOffDates")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate> TimeOffDates
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TimeOffDates == null))
                {
                    this._TimeOffDates = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate>(GetPath("TimeOffDates"));
                }
                return this._TimeOffDates;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate> _TimeOffDates;
        /// <summary>
        /// There are no comments for Balances in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Balances")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance> Balances
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Balances == null))
                {
                    this._Balances = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance>(GetPath("Balances"));
                }
                return this._Balances;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance> _Balances;
        /// <summary>
        /// There are no comments for LeaveRequestDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveRequestDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail> LeaveRequestDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveRequestDetails == null))
                {
                    this._LeaveRequestDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail>(GetPath("LeaveRequestDetails"));
                }
                return this._LeaveRequestDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail> _LeaveRequestDetails;
        /// <summary>
        /// There are no comments for ReportsTimeOffDates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsTimeOffDates")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate> ReportsTimeOffDates
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReportsTimeOffDates == null))
                {
                    this._ReportsTimeOffDates = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate>(GetPath("ReportsTimeOffDates"));
                }
                return this._ReportsTimeOffDates;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate> _ReportsTimeOffDates;
        /// <summary>
        /// There are no comments for LeaveRequestAssignedDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveRequestAssignedDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail> LeaveRequestAssignedDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveRequestAssignedDetails == null))
                {
                    this._LeaveRequestAssignedDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail>(GetPath("LeaveRequestAssignedDetails"));
                }
                return this._LeaveRequestAssignedDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail> _LeaveRequestAssignedDetails;
    }
    /// <summary>
    /// There are no comments for EssLeaveType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LeaveTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LeaveTypeId")]
    [global::Microsoft.OData.Client.EntitySet("EssLeaveTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EssLeaveType")]
    public partial class EssLeaveType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EssLeaveType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="leaveTypeId">Initial value of LeaveTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EssLeaveType CreateEssLeaveType(string dataAreaId, string leaveTypeId)
        {
            EssLeaveType essLeaveType = new EssLeaveType();
            essLeaveType.DataAreaId = dataAreaId;
            essLeaveType.LeaveTypeId = leaveTypeId;
            return essLeaveType;
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
        /// There are no comments for Property LeaveTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaveTypeId is required.")]
        public virtual string LeaveTypeId
        {
            get
            {
                return this._LeaveTypeId;
            }
            set
            {
                this.OnLeaveTypeIdChanging(value);
                this._LeaveTypeId = value;
                this.OnLeaveTypeIdChanged();
                this.OnPropertyChanged("LeaveTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaveTypeId;
        partial void OnLeaveTypeIdChanging(string value);
        partial void OnLeaveTypeIdChanged();
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
        /// There are no comments for Property RequestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveTypeRequestType> RequestType
        {
            get
            {
                return this._RequestType;
            }
            set
            {
                this.OnRequestTypeChanging(value);
                this._RequestType = value;
                this.OnRequestTypeChanged();
                this.OnPropertyChanged("RequestType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveTypeRequestType> _RequestType;
        partial void OnRequestTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveTypeRequestType> value);
        partial void OnRequestTypeChanged();
        /// <summary>
        /// There are no comments for Property IsOpenEnded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsOpenEnded")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsOpenEnded
        {
            get
            {
                return this._IsOpenEnded;
            }
            set
            {
                this.OnIsOpenEndedChanging(value);
                this._IsOpenEnded = value;
                this.OnIsOpenEndedChanged();
                this.OnPropertyChanged("IsOpenEnded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsOpenEnded;
        partial void OnIsOpenEndedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsOpenEndedChanged();
        /// <summary>
        /// There are no comments for Property EnableHalfDayDefinition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnableHalfDayDefinition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableHalfDayDefinition
        {
            get
            {
                return this._EnableHalfDayDefinition;
            }
            set
            {
                this.OnEnableHalfDayDefinitionChanging(value);
                this._EnableHalfDayDefinition = value;
                this.OnEnableHalfDayDefinitionChanged();
                this.OnPropertyChanged("EnableHalfDayDefinition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableHalfDayDefinition;
        partial void OnEnableHalfDayDefinitionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableHalfDayDefinitionChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveTypeCategory> Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveTypeCategory> _Category;
        partial void OnCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveTypeCategory> value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property IsReasonCodeRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsReasonCodeRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsReasonCodeRequired
        {
            get
            {
                return this._IsReasonCodeRequired;
            }
            set
            {
                this.OnIsReasonCodeRequiredChanging(value);
                this._IsReasonCodeRequired = value;
                this.OnIsReasonCodeRequiredChanged();
                this.OnPropertyChanged("IsReasonCodeRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsReasonCodeRequired;
        partial void OnIsReasonCodeRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsReasonCodeRequiredChanged();
        /// <summary>
        /// There are no comments for Property IsAttachmentRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAttachmentRequired")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAttachmentRequired
        {
            get
            {
                return this._IsAttachmentRequired;
            }
            set
            {
                this.OnIsAttachmentRequiredChanging(value);
                this._IsAttachmentRequired = value;
                this.OnIsAttachmentRequiredChanged();
                this.OnPropertyChanged("IsAttachmentRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAttachmentRequired;
        partial void OnIsAttachmentRequiredChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAttachmentRequiredChanged();
        /// <summary>
        /// There are no comments for Property LeaveAmountUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveAmountUnit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveAmountUnit> LeaveAmountUnit
        {
            get
            {
                return this._LeaveAmountUnit;
            }
            set
            {
                this.OnLeaveAmountUnitChanging(value);
                this._LeaveAmountUnit = value;
                this.OnLeaveAmountUnitChanged();
                this.OnPropertyChanged("LeaveAmountUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveAmountUnit> _LeaveAmountUnit;
        partial void OnLeaveAmountUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveAmountUnit> value);
        partial void OnLeaveAmountUnitChanged();
        /// <summary>
        /// There are no comments for Property ReasonCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonCodes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode> ReasonCodes
        {
            get
            {
                return this._ReasonCodes;
            }
            set
            {
                this.OnReasonCodesChanging(value);
                this._ReasonCodes = value;
                this.OnReasonCodesChanged();
                this.OnPropertyChanged("ReasonCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode> _ReasonCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReasonCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTypeReasonCode> value);
        partial void OnReasonCodesChanged();
        /// <summary>
        /// There are no comments for Property TimeOffDates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeOffDates")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate> TimeOffDates
        {
            get
            {
                return this._TimeOffDates;
            }
            set
            {
                this.OnTimeOffDatesChanging(value);
                this._TimeOffDates = value;
                this.OnTimeOffDatesChanged();
                this.OnPropertyChanged("TimeOffDates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate> _TimeOffDates = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTimeOffDatesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveTimeOffDate> value);
        partial void OnTimeOffDatesChanged();
        /// <summary>
        /// There are no comments for Property Balances in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Balances")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance> Balances
        {
            get
            {
                return this._Balances;
            }
            set
            {
                this.OnBalancesChanging(value);
                this._Balances = value;
                this.OnBalancesChanged();
                this.OnPropertyChanged("Balances");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance> _Balances = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBalancesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveBalance> value);
        partial void OnBalancesChanged();
        /// <summary>
        /// There are no comments for Property LeaveRequestDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveRequestDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail> LeaveRequestDetails
        {
            get
            {
                return this._LeaveRequestDetails;
            }
            set
            {
                this.OnLeaveRequestDetailsChanging(value);
                this._LeaveRequestDetails = value;
                this.OnLeaveRequestDetailsChanged();
                this.OnPropertyChanged("LeaveRequestDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail> _LeaveRequestDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeaveRequestDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestDetail> value);
        partial void OnLeaveRequestDetailsChanged();
        /// <summary>
        /// There are no comments for Property ReportsTimeOffDates in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportsTimeOffDates")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate> ReportsTimeOffDates
        {
            get
            {
                return this._ReportsTimeOffDates;
            }
            set
            {
                this.OnReportsTimeOffDatesChanging(value);
                this._ReportsTimeOffDates = value;
                this.OnReportsTimeOffDatesChanged();
                this.OnPropertyChanged("ReportsTimeOffDates");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate> _ReportsTimeOffDates = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReportsTimeOffDatesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.MssLeaveTimeOffDate> value);
        partial void OnReportsTimeOffDatesChanged();
        /// <summary>
        /// There are no comments for Property LeaveRequestAssignedDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveRequestAssignedDetails")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail> LeaveRequestAssignedDetails
        {
            get
            {
                return this._LeaveRequestAssignedDetails;
            }
            set
            {
                this.OnLeaveRequestAssignedDetailsChanging(value);
                this._LeaveRequestAssignedDetails = value;
                this.OnLeaveRequestAssignedDetailsChanged();
                this.OnPropertyChanged("LeaveRequestAssignedDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail> _LeaveRequestAssignedDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeaveRequestAssignedDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EssLeaveRequestAssignedDetail> value);
        partial void OnLeaveRequestAssignedDetailsChanged();
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
