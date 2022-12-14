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
    /// There are no comments for NameSequenceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("NameSequenceSingle")]
    public partial class NameSequenceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<NameSequence>
    {
        /// <summary>
        /// Initialize a new NameSequenceSingle object.
        /// </summary>
        public NameSequenceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new NameSequenceSingle object.
        /// </summary>
        public NameSequenceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new NameSequenceSingle object.
        /// </summary>
        public NameSequenceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<NameSequence> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for NameSequence in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NameSequence
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("NameSequence", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("NameSequences")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("NameSequence")]
    public partial class NameSequence : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NameSequence object.
        /// </summary>
        /// <param name="nameSequence1">Initial value of NameSequence1.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="separator2Spaces">Initial value of Separator2Spaces.</param>
        /// <param name="separator1Spaces">Initial value of Separator1Spaces.</param>
        /// <param name="separator3Spaces">Initial value of Separator3Spaces.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static NameSequence CreateNameSequence(string nameSequence1, string languageId, int separator2Spaces, int separator1Spaces, int separator3Spaces)
        {
            NameSequence nameSequence = new NameSequence();
            nameSequence.NameSequence1 = nameSequence1;
            nameSequence.LanguageId = languageId;
            nameSequence.Separator2Spaces = separator2Spaces;
            nameSequence.Separator1Spaces = separator1Spaces;
            nameSequence.Separator3Spaces = separator3Spaces;
            return nameSequence;
        }
        /// <summary>
        /// There are no comments for Property NameSequence1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameSequence")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NameSequence1 is required.")]
        public virtual string NameSequence1
        {
            get
            {
                return this._NameSequence1;
            }
            set
            {
                this.OnNameSequence1Changing(value);
                this._NameSequence1 = value;
                this.OnNameSequence1Changed();
                this.OnPropertyChanged("NameSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameSequence1;
        partial void OnNameSequence1Changing(string value);
        partial void OnNameSequence1Changed();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LanguageId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LanguageId is required.")]
        public virtual string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
        /// <summary>
        /// There are no comments for Property Separator3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Separator3")]
        public virtual string Separator3
        {
            get
            {
                return this._Separator3;
            }
            set
            {
                this.OnSeparator3Changing(value);
                this._Separator3 = value;
                this.OnSeparator3Changed();
                this.OnPropertyChanged("Separator3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Separator3;
        partial void OnSeparator3Changing(string value);
        partial void OnSeparator3Changed();
        /// <summary>
        /// There are no comments for Property Separator2Spaces in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Separator2Spaces")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Separator2Spaces is required.")]
        public virtual int Separator2Spaces
        {
            get
            {
                return this._Separator2Spaces;
            }
            set
            {
                this.OnSeparator2SpacesChanging(value);
                this._Separator2Spaces = value;
                this.OnSeparator2SpacesChanged();
                this.OnPropertyChanged("Separator2Spaces");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Separator2Spaces;
        partial void OnSeparator2SpacesChanging(int value);
        partial void OnSeparator2SpacesChanged();
        /// <summary>
        /// There are no comments for Property LastPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastPosition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> LastPosition
        {
            get
            {
                return this._LastPosition;
            }
            set
            {
                this.OnLastPositionChanging(value);
                this._LastPosition = value;
                this.OnLastPositionChanged();
                this.OnPropertyChanged("LastPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> _LastPosition;
        partial void OnLastPositionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> value);
        partial void OnLastPositionChanged();
        /// <summary>
        /// There are no comments for Property Separator1Spaces in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Separator1Spaces")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Separator1Spaces is required.")]
        public virtual int Separator1Spaces
        {
            get
            {
                return this._Separator1Spaces;
            }
            set
            {
                this.OnSeparator1SpacesChanging(value);
                this._Separator1Spaces = value;
                this.OnSeparator1SpacesChanged();
                this.OnPropertyChanged("Separator1Spaces");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Separator1Spaces;
        partial void OnSeparator1SpacesChanging(int value);
        partial void OnSeparator1SpacesChanged();
        /// <summary>
        /// There are no comments for Property SecondPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SecondPosition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> SecondPosition
        {
            get
            {
                return this._SecondPosition;
            }
            set
            {
                this.OnSecondPositionChanging(value);
                this._SecondPosition = value;
                this.OnSecondPositionChanged();
                this.OnPropertyChanged("SecondPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> _SecondPosition;
        partial void OnSecondPositionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> value);
        partial void OnSecondPositionChanged();
        /// <summary>
        /// There are no comments for Property FirstPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FirstPosition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> FirstPosition
        {
            get
            {
                return this._FirstPosition;
            }
            set
            {
                this.OnFirstPositionChanging(value);
                this._FirstPosition = value;
                this.OnFirstPositionChanged();
                this.OnPropertyChanged("FirstPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> _FirstPosition;
        partial void OnFirstPositionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> value);
        partial void OnFirstPositionChanged();
        /// <summary>
        /// There are no comments for Property ThirdPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ThirdPosition")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> ThirdPosition
        {
            get
            {
                return this._ThirdPosition;
            }
            set
            {
                this.OnThirdPositionChanging(value);
                this._ThirdPosition = value;
                this.OnThirdPositionChanged();
                this.OnPropertyChanged("ThirdPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> _ThirdPosition;
        partial void OnThirdPositionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSubNameSequenceType> value);
        partial void OnThirdPositionChanged();
        /// <summary>
        /// There are no comments for Property Separator1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Separator1")]
        public virtual string Separator1
        {
            get
            {
                return this._Separator1;
            }
            set
            {
                this.OnSeparator1Changing(value);
                this._Separator1 = value;
                this.OnSeparator1Changed();
                this.OnPropertyChanged("Separator1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Separator1;
        partial void OnSeparator1Changing(string value);
        partial void OnSeparator1Changed();
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
        /// There are no comments for Property Separator3Spaces in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Separator3Spaces")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Separator3Spaces is required.")]
        public virtual int Separator3Spaces
        {
            get
            {
                return this._Separator3Spaces;
            }
            set
            {
                this.OnSeparator3SpacesChanging(value);
                this._Separator3Spaces = value;
                this.OnSeparator3SpacesChanged();
                this.OnPropertyChanged("Separator3Spaces");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Separator3Spaces;
        partial void OnSeparator3SpacesChanging(int value);
        partial void OnSeparator3SpacesChanged();
        /// <summary>
        /// There are no comments for Property Separator2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Separator2")]
        public virtual string Separator2
        {
            get
            {
                return this._Separator2;
            }
            set
            {
                this.OnSeparator2Changing(value);
                this._Separator2 = value;
                this.OnSeparator2Changed();
                this.OnPropertyChanged("Separator2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Separator2;
        partial void OnSeparator2Changing(string value);
        partial void OnSeparator2Changed();
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
