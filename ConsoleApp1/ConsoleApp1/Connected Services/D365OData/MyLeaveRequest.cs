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
    /// There are no comments for MyLeaveRequestSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MyLeaveRequestSingle")]
    public partial class MyLeaveRequestSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MyLeaveRequest>
    {
        /// <summary>
        /// Initialize a new MyLeaveRequestSingle object.
        /// </summary>
        public MyLeaveRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MyLeaveRequestSingle object.
        /// </summary>
        public MyLeaveRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MyLeaveRequestSingle object.
        /// </summary>
        public MyLeaveRequestSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MyLeaveRequest> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MyLeaveRequest in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RequestId
    /// LeaveType
    /// LeaveDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RequestId", "LeaveType", "LeaveDate")]
    [global::Microsoft.OData.Client.EntitySet("MyLeaveRequests")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MyLeaveRequest")]
    public partial class MyLeaveRequest : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MyLeaveRequest object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="requestId">Initial value of RequestId.</param>
        /// <param name="leaveType">Initial value of LeaveType.</param>
        /// <param name="leaveDate">Initial value of LeaveDate.</param>
        /// <param name="requestDate">Initial value of RequestDate.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MyLeaveRequest CreateMyLeaveRequest(string dataAreaId, 
                    string requestId, 
                    string leaveType, 
                    global::System.DateTimeOffset leaveDate, 
                    global::System.DateTimeOffset requestDate, 
                    decimal amount)
        {
            MyLeaveRequest myLeaveRequest = new MyLeaveRequest();
            myLeaveRequest.DataAreaId = dataAreaId;
            myLeaveRequest.RequestId = requestId;
            myLeaveRequest.LeaveType = leaveType;
            myLeaveRequest.LeaveDate = leaveDate;
            myLeaveRequest.RequestDate = requestDate;
            myLeaveRequest.Amount = amount;
            return myLeaveRequest;
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
        /// There are no comments for Property LeaveType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaveType is required.")]
        public virtual string LeaveType
        {
            get
            {
                return this._LeaveType;
            }
            set
            {
                this.OnLeaveTypeChanging(value);
                this._LeaveType = value;
                this.OnLeaveTypeChanged();
                this.OnPropertyChanged("LeaveType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LeaveType;
        partial void OnLeaveTypeChanging(string value);
        partial void OnLeaveTypeChanged();
        /// <summary>
        /// There are no comments for Property LeaveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaveDate is required.")]
        public virtual global::System.DateTimeOffset LeaveDate
        {
            get
            {
                return this._LeaveDate;
            }
            set
            {
                this.OnLeaveDateChanging(value);
                this._LeaveDate = value;
                this.OnLeaveDateChanged();
                this.OnPropertyChanged("LeaveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _LeaveDate;
        partial void OnLeaveDateChanging(global::System.DateTimeOffset value);
        partial void OnLeaveDateChanged();
        /// <summary>
        /// There are no comments for Property ReasonCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReasonCodeId")]
        public virtual string ReasonCodeId
        {
            get
            {
                return this._ReasonCodeId;
            }
            set
            {
                this.OnReasonCodeIdChanging(value);
                this._ReasonCodeId = value;
                this.OnReasonCodeIdChanged();
                this.OnPropertyChanged("ReasonCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCodeId;
        partial void OnReasonCodeIdChanging(string value);
        partial void OnReasonCodeIdChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property RequestDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequestDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RequestDate is required.")]
        public virtual global::System.DateTimeOffset RequestDate
        {
            get
            {
                return this._RequestDate;
            }
            set
            {
                this.OnRequestDateChanging(value);
                this._RequestDate = value;
                this.OnRequestDateChanged();
                this.OnPropertyChanged("RequestDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RequestDate;
        partial void OnRequestDateChanging(global::System.DateTimeOffset value);
        partial void OnRequestDateChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comment")]
        public virtual string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveRequestApprovalStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveRequestApprovalStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveRequestApprovalStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property HalfDayDefinition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("HalfDayDefinition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveHalfDayDefinition> HalfDayDefinition
        {
            get
            {
                return this._HalfDayDefinition;
            }
            set
            {
                this.OnHalfDayDefinitionChanging(value);
                this._HalfDayDefinition = value;
                this.OnHalfDayDefinitionChanged();
                this.OnPropertyChanged("HalfDayDefinition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveHalfDayDefinition> _HalfDayDefinition;
        partial void OnHalfDayDefinitionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveHalfDayDefinition> value);
        partial void OnHalfDayDefinitionChanged();
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
        /// <summary>
        /// There are no comments for Submit in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("submit")]
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery Submit()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.submit");
        }
        /// <summary>
        /// There are no comments for SubmitLeave in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("submitLeave")]
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery SubmitLeave()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/Microsoft.Dynamics.DataEntities.submitLeave");
        }
    }
}
