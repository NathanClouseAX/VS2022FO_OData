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
    /// There are no comments for PersonExamSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonExamSingle")]
    public partial class PersonExamSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PersonExam>
    {
        /// <summary>
        /// Initialize a new PersonExamSingle object.
        /// </summary>
        public PersonExamSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PersonExamSingle object.
        /// </summary>
        public PersonExamSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PersonExamSingle object.
        /// </summary>
        public PersonExamSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PersonExam> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TestType")]
        public virtual global::Microsoft.Dynamics.DataEntities.TestTypeSingle TestType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TestType == null))
                {
                    this._TestType = new global::Microsoft.Dynamics.DataEntities.TestTypeSingle(this.Context, GetPath("TestType"));
                }
                return this._TestType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TestTypeSingle _TestType;
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
    /// There are no comments for PersonExam in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// TestId
    /// RequiredBy
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber", "TestId", "RequiredBy")]
    [global::Microsoft.OData.Client.EntitySet("PersonExams")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonExam")]
    public partial class PersonExam : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonExam object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="testId">Initial value of TestId.</param>
        /// <param name="requiredBy">Initial value of RequiredBy.</param>
        /// <param name="score">Initial value of Score.</param>
        /// <param name="completedOn">Initial value of CompletedOn.</param>
        /// <param name="testType">Initial value of TestType.</param>
        /// <param name="person">Initial value of Person.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PersonExam CreatePersonExam(string partyNumber, 
                    string testId, 
                    global::System.DateTimeOffset requiredBy, 
                    int score, 
                    global::System.DateTimeOffset completedOn, 
                    global::Microsoft.Dynamics.DataEntities.TestType testType, 
                    global::Microsoft.Dynamics.DataEntities.Person person)
        {
            PersonExam personExam = new PersonExam();
            personExam.PartyNumber = partyNumber;
            personExam.TestId = testId;
            personExam.RequiredBy = requiredBy;
            personExam.Score = score;
            personExam.CompletedOn = completedOn;
            if ((testType == null))
            {
                throw new global::System.ArgumentNullException("testType");
            }
            personExam.TestType = testType;
            if ((person == null))
            {
                throw new global::System.ArgumentNullException("person");
            }
            personExam.Person = person;
            return personExam;
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
        /// There are no comments for Property TestId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TestId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TestId is required.")]
        public virtual string TestId
        {
            get
            {
                return this._TestId;
            }
            set
            {
                this.OnTestIdChanging(value);
                this._TestId = value;
                this.OnTestIdChanged();
                this.OnPropertyChanged("TestId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TestId;
        partial void OnTestIdChanging(string value);
        partial void OnTestIdChanged();
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
        /// There are no comments for Property Score in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Score")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Score is required.")]
        public virtual int Score
        {
            get
            {
                return this._Score;
            }
            set
            {
                this.OnScoreChanging(value);
                this._Score = value;
                this.OnScoreChanged();
                this.OnPropertyChanged("Score");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Score;
        partial void OnScoreChanging(int value);
        partial void OnScoreChanged();
        /// <summary>
        /// There are no comments for Property CompletedOn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompletedOn")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompletedOn is required.")]
        public virtual global::System.DateTimeOffset CompletedOn
        {
            get
            {
                return this._CompletedOn;
            }
            set
            {
                this.OnCompletedOnChanging(value);
                this._CompletedOn = value;
                this.OnCompletedOnChanged();
                this.OnPropertyChanged("CompletedOn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CompletedOn;
        partial void OnCompletedOnChanging(global::System.DateTimeOffset value);
        partial void OnCompletedOnChanged();
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
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property TestType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TestType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TestType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.TestType TestType
        {
            get
            {
                return this._TestType;
            }
            set
            {
                this.OnTestTypeChanging(value);
                this._TestType = value;
                this.OnTestTypeChanged();
                this.OnPropertyChanged("TestType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TestType _TestType;
        partial void OnTestTypeChanging(global::Microsoft.Dynamics.DataEntities.TestType value);
        partial void OnTestTypeChanged();
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
