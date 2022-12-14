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
    /// There are no comments for PersonScreeningSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonScreeningSingle")]
    public partial class PersonScreeningSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonScreening>
    {
        /// <summary>
        /// Initialize a new PersonScreeningSingle object.
        /// </summary>
        public PersonScreeningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonScreeningSingle object.
        /// </summary>
        public PersonScreeningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonScreeningSingle object.
        /// </summary>
        public PersonScreeningSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonScreening> query)
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
    /// There are no comments for PersonScreening in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// ScreeningTypeId
    /// RequiredBy
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "ScreeningTypeId", "RequiredBy")]
    [global::Microsoft.OData.Client.EntitySet("PersonScreenings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonScreening")]
    public partial class PersonScreening : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonScreening object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="screeningTypeId">Initial value of ScreeningTypeId.</param>
        /// <param name="requiredBy">Initial value of RequiredBy.</param>
        /// <param name="completedDate">Initial value of CompletedDate.</param>
        /// <param name="person">Initial value of Person.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonScreening CreatePersonScreening(string partyNumber, string screeningTypeId, global::System.DateTimeOffset requiredBy, global::System.DateTimeOffset completedDate, global::Microsoft.Dynamics.DataEntities.Person person)
        {
            PersonScreening personScreening = new PersonScreening();
            personScreening.PartyNumber = partyNumber;
            personScreening.ScreeningTypeId = screeningTypeId;
            personScreening.RequiredBy = requiredBy;
            personScreening.CompletedDate = completedDate;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personScreening.Person = person;
            return personScreening;
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
        /// There are no comments for Property ScreeningTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScreeningTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ScreeningTypeId is required.")]
        public virtual string ScreeningTypeId
        {
            get
            {
                return this._ScreeningTypeId;
            }
            set
            {
                this.OnScreeningTypeIdChanging(value);
                this._ScreeningTypeId = value;
                this.OnScreeningTypeIdChanged();
                this.OnPropertyChanged("ScreeningTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScreeningTypeId;
        partial void OnScreeningTypeIdChanging(string value);
        partial void OnScreeningTypeIdChanged();
        /// <summary>
        /// There are no comments for Property RequiredBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequiredBy")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RequiredBy is required.")]
        public virtual global::System.DateTimeOffset RequiredBy
        {
            get
            {
                return this._RequiredBy;
            }
            set
            {
                this.OnRequiredByChanging(value);
                this._RequiredBy = value;
                this.OnRequiredByChanged();
                this.OnPropertyChanged("RequiredBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RequiredBy;
        partial void OnRequiredByChanging(global::System.DateTimeOffset value);
        partial void OnRequiredByChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompletionStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompletionStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmCompletionStatus> value);
        partial void OnStatusChanged();
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
        /// There are no comments for Property CompletedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompletedDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompletedDate is required.")]
        public virtual global::System.DateTimeOffset CompletedDate
        {
            get
            {
                return this._CompletedDate;
            }
            set
            {
                this.OnCompletedDateChanging(value);
                this._CompletedDate = value;
                this.OnCompletedDateChanged();
                this.OnPropertyChanged("CompletedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CompletedDate;
        partial void OnCompletedDateChanging(global::System.DateTimeOffset value);
        partial void OnCompletedDateChanged();
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
