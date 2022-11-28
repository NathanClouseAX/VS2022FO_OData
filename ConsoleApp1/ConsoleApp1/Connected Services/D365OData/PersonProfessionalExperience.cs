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
    /// There are no comments for PersonProfessionalExperienceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonProfessionalExperienceSingle")]
    public partial class PersonProfessionalExperienceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonProfessionalExperience>
    {
        /// <summary>
        /// Initialize a new PersonProfessionalExperienceSingle object.
        /// </summary>
        public PersonProfessionalExperienceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonProfessionalExperienceSingle object.
        /// </summary>
        public PersonProfessionalExperienceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonProfessionalExperienceSingle object.
        /// </summary>
        public PersonProfessionalExperienceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonProfessionalExperience> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Person")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle Person
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Person == null))
                {
                    this._Person = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("Person"));
                }
                return this._Person;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _Person;
    }
    /// <summary>
    /// There are no comments for PersonProfessionalExperience in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// StartDate
    /// EmployerPosition
    /// EmployerName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "StartDate", "EmployerPosition", "EmployerName")]
    [global::Microsoft.OData.Client.EntitySet("PersonProfessionalExperiences")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonProfessionalExperience")]
    public partial class PersonProfessionalExperience : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonProfessionalExperience object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="employerPosition">Initial value of EmployerPosition.</param>
        /// <param name="employerName">Initial value of EmployerName.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="person">Initial value of Person.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonProfessionalExperience CreatePersonProfessionalExperience(string partyNumber, 
                    global::System.DateTimeOffset startDate, 
                    string employerPosition, 
                    string employerName, 
                    global::System.DateTimeOffset endDate, 
                    global::Microsoft.Dynamics.DataEntities.Person person)
        {
            PersonProfessionalExperience personProfessionalExperience = new PersonProfessionalExperience();
            personProfessionalExperience.PartyNumber = partyNumber;
            personProfessionalExperience.StartDate = startDate;
            personProfessionalExperience.EmployerPosition = employerPosition;
            personProfessionalExperience.EmployerName = employerName;
            personProfessionalExperience.EndDate = endDate;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personProfessionalExperience.Person = person;
            return personProfessionalExperience;
        }
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartyNumber is required.")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property EmployerPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployerPosition")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmployerPosition is required.")]
        public virtual string EmployerPosition
        {
            get
            {
                return this._EmployerPosition;
            }
            set
            {
                this.OnEmployerPositionChanging(value);
                this._EmployerPosition = value;
                this.OnEmployerPositionChanged();
                this.OnPropertyChanged("EmployerPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmployerPosition;
        partial void OnEmployerPositionChanging(string value);
        partial void OnEmployerPositionChanged();
        /// <summary>
        /// There are no comments for Property EmployerName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployerName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EmployerName is required.")]
        public virtual string EmployerName
        {
            get
            {
                return this._EmployerName;
            }
            set
            {
                this.OnEmployerNameChanging(value);
                this._EmployerName = value;
                this.OnEmployerNameChanged();
                this.OnPropertyChanged("EmployerName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmployerName;
        partial void OnEmployerNameChanging(string value);
        partial void OnEmployerNameChanged();
        /// <summary>
        /// There are no comments for Property AllowContactEmployer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowContactEmployer")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmBlankYesNo> AllowContactEmployer
        {
            get
            {
                return this._AllowContactEmployer;
            }
            set
            {
                this.OnAllowContactEmployerChanging(value);
                this._AllowContactEmployer = value;
                this.OnAllowContactEmployerChanged();
                this.OnPropertyChanged("AllowContactEmployer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmBlankYesNo> _AllowContactEmployer;
        partial void OnAllowContactEmployerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmBlankYesNo> value);
        partial void OnAllowContactEmployerChanged();
        /// <summary>
        /// There are no comments for Property URL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("URL")]
        public virtual string URL
        {
            get
            {
                return this._URL;
            }
            set
            {
                this.OnURLChanging(value);
                this._URL = value;
                this.OnURLChanged();
                this.OnPropertyChanged("URL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _URL;
        partial void OnURLChanging(string value);
        partial void OnURLChanged();
        /// <summary>
        /// There are no comments for Property EmployerLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployerLocation")]
        public virtual string EmployerLocation
        {
            get
            {
                return this._EmployerLocation;
            }
            set
            {
                this.OnEmployerLocationChanging(value);
                this._EmployerLocation = value;
                this.OnEmployerLocationChanged();
                this.OnPropertyChanged("EmployerLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmployerLocation;
        partial void OnEmployerLocationChanging(string value);
        partial void OnEmployerLocationChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Note")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property Phone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Phone")]
        public virtual string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Phone;
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
        /// <summary>
        /// There are no comments for Property Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Person")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Person is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this.OnPersonChanging(value);
                this._Person = value;
                this.OnPersonChanged();
                this.OnPropertyChanged("Person");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _Person;
        partial void OnPersonChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnPersonChanged();
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
