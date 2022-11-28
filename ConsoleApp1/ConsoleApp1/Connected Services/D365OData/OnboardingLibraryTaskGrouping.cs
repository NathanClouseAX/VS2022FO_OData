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
    /// There are no comments for OnboardingLibraryTaskGroupingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OnboardingLibraryTaskGroupingSingle")]
    public partial class OnboardingLibraryTaskGroupingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<OnboardingLibraryTaskGrouping>
    {
        /// <summary>
        /// Initialize a new OnboardingLibraryTaskGroupingSingle object.
        /// </summary>
        public OnboardingLibraryTaskGroupingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OnboardingLibraryTaskGroupingSingle object.
        /// </summary>
        public OnboardingLibraryTaskGroupingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OnboardingLibraryTaskGroupingSingle object.
        /// </summary>
        public OnboardingLibraryTaskGroupingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<OnboardingLibraryTaskGrouping> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LibraryTaskGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LibraryTaskGroup")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroupSingle LibraryTaskGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LibraryTaskGroup == null))
                {
                    this._LibraryTaskGroup = new global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroupSingle(this.Context, GetPath("LibraryTaskGroup"));
                }
                return this._LibraryTaskGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroupSingle _LibraryTaskGroup;
        /// <summary>
        /// There are no comments for LibraryTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LibraryTask")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskSingle LibraryTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LibraryTask == null))
                {
                    this._LibraryTask = new global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskSingle(this.Context, GetPath("LibraryTask"));
                }
                return this._LibraryTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskSingle _LibraryTask;
    }
    /// <summary>
    /// There are no comments for OnboardingLibraryTaskGrouping in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TaskName
    /// TaskGroupName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TaskName", "TaskGroupName")]
    [global::Microsoft.OData.Client.EntitySet("OnboardingLibraryTaskGroupings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("OnboardingLibraryTaskGrouping")]
    public partial class OnboardingLibraryTaskGrouping : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OnboardingLibraryTaskGrouping object.
        /// </summary>
        /// <param name="taskName">Initial value of TaskName.</param>
        /// <param name="taskGroupName">Initial value of TaskGroupName.</param>
        /// <param name="libraryTaskGroup">Initial value of LibraryTaskGroup.</param>
        /// <param name="libraryTask">Initial value of LibraryTask.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OnboardingLibraryTaskGrouping CreateOnboardingLibraryTaskGrouping(string taskName, string taskGroupName, global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroup libraryTaskGroup, global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTask libraryTask)
        {
            OnboardingLibraryTaskGrouping onboardingLibraryTaskGrouping = new OnboardingLibraryTaskGrouping();
            onboardingLibraryTaskGrouping.TaskName = taskName;
            onboardingLibraryTaskGrouping.TaskGroupName = taskGroupName;
            if ((libraryTaskGroup == null))
            {
                throw new global::System.ArgumentNullException("libraryTaskGroup");
            }
            onboardingLibraryTaskGrouping.LibraryTaskGroup = libraryTaskGroup;
            if ((libraryTask == null))
            {
                throw new global::System.ArgumentNullException("libraryTask");
            }
            onboardingLibraryTaskGrouping.LibraryTask = libraryTask;
            return onboardingLibraryTaskGrouping;
        }
        /// <summary>
        /// There are no comments for Property TaskName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaskName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaskName is required.")]
        public virtual string TaskName
        {
            get
            {
                return this._TaskName;
            }
            set
            {
                this.OnTaskNameChanging(value);
                this._TaskName = value;
                this.OnTaskNameChanged();
                this.OnPropertyChanged("TaskName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaskName;
        partial void OnTaskNameChanging(string value);
        partial void OnTaskNameChanged();
        /// <summary>
        /// There are no comments for Property TaskGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaskGroupName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaskGroupName is required.")]
        public virtual string TaskGroupName
        {
            get
            {
                return this._TaskGroupName;
            }
            set
            {
                this.OnTaskGroupNameChanging(value);
                this._TaskGroupName = value;
                this.OnTaskGroupNameChanged();
                this.OnPropertyChanged("TaskGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaskGroupName;
        partial void OnTaskGroupNameChanging(string value);
        partial void OnTaskGroupNameChanged();
        /// <summary>
        /// There are no comments for Property LibraryTaskGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LibraryTaskGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LibraryTaskGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroup LibraryTaskGroup
        {
            get
            {
                return this._LibraryTaskGroup;
            }
            set
            {
                this.OnLibraryTaskGroupChanging(value);
                this._LibraryTaskGroup = value;
                this.OnLibraryTaskGroupChanged();
                this.OnPropertyChanged("LibraryTaskGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroup _LibraryTaskGroup;
        partial void OnLibraryTaskGroupChanging(global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTaskGroup value);
        partial void OnLibraryTaskGroupChanged();
        /// <summary>
        /// There are no comments for Property LibraryTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LibraryTask")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LibraryTask is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTask LibraryTask
        {
            get
            {
                return this._LibraryTask;
            }
            set
            {
                this.OnLibraryTaskChanging(value);
                this._LibraryTask = value;
                this.OnLibraryTaskChanged();
                this.OnPropertyChanged("LibraryTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTask _LibraryTask;
        partial void OnLibraryTaskChanging(global::Microsoft.Dynamics.DataEntities.OnboardingLibraryTask value);
        partial void OnLibraryTaskChanged();
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