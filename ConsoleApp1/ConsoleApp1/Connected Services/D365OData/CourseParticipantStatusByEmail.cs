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
    /// There are no comments for CourseParticipantStatusByEmailSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CourseParticipantStatusByEmailSingle")]
    public partial class CourseParticipantStatusByEmailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseParticipantStatusByEmail>
    {
        /// <summary>
        /// Initialize a new CourseParticipantStatusByEmailSingle object.
        /// </summary>
        public CourseParticipantStatusByEmailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseParticipantStatusByEmailSingle object.
        /// </summary>
        public CourseParticipantStatusByEmailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseParticipantStatusByEmailSingle object.
        /// </summary>
        public CourseParticipantStatusByEmailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseParticipantStatusByEmail> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CourseParticipantStatusByEmail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CourseId
    /// UserEmail
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CourseId", "UserEmail")]
    [global::Microsoft.OData.Client.EntitySet("CourseParticipantsStatusByEmail")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CourseParticipantStatusByEmail")]
    public partial class CourseParticipantStatusByEmail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseParticipantStatusByEmail object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="courseId">Initial value of CourseId.</param>
        /// <param name="userEmail">Initial value of UserEmail.</param>
        /// <param name="dueDate">Initial value of DueDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseParticipantStatusByEmail CreateCourseParticipantStatusByEmail(string dataAreaId, string courseId, string userEmail, global::System.DateTimeOffset dueDate)
        {
            CourseParticipantStatusByEmail courseParticipantStatusByEmail = new CourseParticipantStatusByEmail();
            courseParticipantStatusByEmail.DataAreaId = dataAreaId;
            courseParticipantStatusByEmail.CourseId = courseId;
            courseParticipantStatusByEmail.UserEmail = userEmail;
            courseParticipantStatusByEmail.DueDate = dueDate;
            return courseParticipantStatusByEmail;
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
        /// There are no comments for Property CourseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CourseId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CourseId is required.")]
        public virtual string CourseId
        {
            get
            {
                return this._CourseId;
            }
            set
            {
                this.OnCourseIdChanging(value);
                this._CourseId = value;
                this.OnCourseIdChanged();
                this.OnPropertyChanged("CourseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseId;
        partial void OnCourseIdChanging(string value);
        partial void OnCourseIdChanged();
        /// <summary>
        /// There are no comments for Property UserEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserEmail")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UserEmail is required.")]
        public virtual string UserEmail
        {
            get
            {
                return this._UserEmail;
            }
            set
            {
                this.OnUserEmailChanging(value);
                this._UserEmail = value;
                this.OnUserEmailChanged();
                this.OnPropertyChanged("UserEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserEmail;
        partial void OnUserEmailChanging(string value);
        partial void OnUserEmailChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DueDate is required.")]
        public virtual global::System.DateTimeOffset DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DueDate;
        partial void OnDueDateChanging(global::System.DateTimeOffset value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCourseAttendeeStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FirstName")]
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
                this.OnPropertyChanged("FirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastName")]
        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
                this.OnPropertyChanged("LastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
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
