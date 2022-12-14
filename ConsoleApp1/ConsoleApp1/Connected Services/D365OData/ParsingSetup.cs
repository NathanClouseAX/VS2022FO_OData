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
    /// There are no comments for ParsingSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ParsingSetupSingle")]
    public partial class ParsingSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ParsingSetup>
    {
        /// <summary>
        /// Initialize a new ParsingSetupSingle object.
        /// </summary>
        public ParsingSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ParsingSetupSingle object.
        /// </summary>
        public ParsingSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ParsingSetupSingle object.
        /// </summary>
        public ParsingSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ParsingSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ParsingSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Identifier
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Identifier")]
    [global::Microsoft.OData.Client.EntitySet("ParsingSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ParsingSetup")]
    public partial class ParsingSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ParsingSetup object.
        /// </summary>
        /// <param name="identifier">Initial value of Identifier.</param>
        /// <param name="length">Initial value of Length.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ParsingSetup CreateParsingSetup(string identifier, int length)
        {
            ParsingSetup parsingSetup = new ParsingSetup();
            parsingSetup.Identifier = identifier;
            parsingSetup.Length = length;
            return parsingSetup;
        }
        /// <summary>
        /// There are no comments for Property Identifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Identifier")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Identifier is required.")]
        public virtual string Identifier
        {
            get
            {
                return this._Identifier;
            }
            set
            {
                this.OnIdentifierChanging(value);
                this._Identifier = value;
                this.OnIdentifierChanged();
                this.OnPropertyChanged("Identifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Identifier;
        partial void OnIdentifierChanging(string value);
        partial void OnIdentifierChanged();
        /// <summary>
        /// There are no comments for Property IsFixedLength in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsFixedLength")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsFixedLength
        {
            get
            {
                return this._IsFixedLength;
            }
            set
            {
                this.OnIsFixedLengthChanging(value);
                this._IsFixedLength = value;
                this.OnIsFixedLengthChanged();
                this.OnPropertyChanged("IsFixedLength");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsFixedLength;
        partial void OnIsFixedLengthChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsFixedLengthChanged();
        /// <summary>
        /// There are no comments for Property Length in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Length")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Length is required.")]
        public virtual int Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                this.OnLengthChanging(value);
                this._Length = value;
                this.OnLengthChanged();
                this.OnPropertyChanged("Length");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Length;
        partial void OnLengthChanging(int value);
        partial void OnLengthChanged();
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
        /// There are no comments for Property IsDecimal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDecimal")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDecimal
        {
            get
            {
                return this._IsDecimal;
            }
            set
            {
                this.OnIsDecimalChanging(value);
                this._IsDecimal = value;
                this.OnIsDecimalChanged();
                this.OnPropertyChanged("IsDecimal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDecimal;
        partial void OnIsDecimalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDecimalChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSGS1Type> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSGS1Type> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.WHSGS1Type> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property AddIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AddIdentifier")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AddIdentifier
        {
            get
            {
                return this._AddIdentifier;
            }
            set
            {
                this.OnAddIdentifierChanging(value);
                this._AddIdentifier = value;
                this.OnAddIdentifierChanged();
                this.OnPropertyChanged("AddIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AddIdentifier;
        partial void OnAddIdentifierChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAddIdentifierChanged();
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
