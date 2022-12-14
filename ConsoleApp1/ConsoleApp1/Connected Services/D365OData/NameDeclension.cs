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
    /// There are no comments for NameDeclensionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("NameDeclensionSingle")]
    public partial class NameDeclensionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<NameDeclension>
    {
        /// <summary>
        /// Initialize a new NameDeclensionSingle object.
        /// </summary>
        public NameDeclensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new NameDeclensionSingle object.
        /// </summary>
        public NameDeclensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new NameDeclensionSingle object.
        /// </summary>
        public NameDeclensionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<NameDeclension> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for NameDeclension in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CurrencyCode
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CurrencyCode", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("NameDeclensions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("NameDeclension")]
    public partial class NameDeclension : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NameDeclension object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="currencyCode">Initial value of CurrencyCode.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static NameDeclension CreateNameDeclension(string dataAreaId, string currencyCode, string languageId)
        {
            NameDeclension nameDeclension = new NameDeclension();
            nameDeclension.DataAreaId = dataAreaId;
            nameDeclension.CurrencyCode = currencyCode;
            nameDeclension.LanguageId = languageId;
            return nameDeclension;
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
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CurrencyCode is required.")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
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
        /// There are no comments for Property Gender in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Gender")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrencyGender_W> Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                this.OnGenderChanging(value);
                this._Gender = value;
                this.OnGenderChanged();
                this.OnPropertyChanged("Gender");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrencyGender_W> _Gender;
        partial void OnGenderChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrencyGender_W> value);
        partial void OnGenderChanged();
        /// <summary>
        /// There are no comments for Property NameForOne in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameForOne")]
        public virtual string NameForOne
        {
            get
            {
                return this._NameForOne;
            }
            set
            {
                this.OnNameForOneChanging(value);
                this._NameForOne = value;
                this.OnNameForOneChanged();
                this.OnPropertyChanged("NameForOne");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameForOne;
        partial void OnNameForOneChanging(string value);
        partial void OnNameForOneChanged();
        /// <summary>
        /// There are no comments for Property CurrencyPluralNominativePenny in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyPluralNominativePenny")]
        public virtual string CurrencyPluralNominativePenny
        {
            get
            {
                return this._CurrencyPluralNominativePenny;
            }
            set
            {
                this.OnCurrencyPluralNominativePennyChanging(value);
                this._CurrencyPluralNominativePenny = value;
                this.OnCurrencyPluralNominativePennyChanged();
                this.OnPropertyChanged("CurrencyPluralNominativePenny");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyPluralNominativePenny;
        partial void OnCurrencyPluralNominativePennyChanging(string value);
        partial void OnCurrencyPluralNominativePennyChanged();
        /// <summary>
        /// There are no comments for Property InsertAndBeforePenny in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InsertAndBeforePenny")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InsertAndBeforePenny
        {
            get
            {
                return this._InsertAndBeforePenny;
            }
            set
            {
                this.OnInsertAndBeforePennyChanging(value);
                this._InsertAndBeforePenny = value;
                this.OnInsertAndBeforePennyChanged();
                this.OnPropertyChanged("InsertAndBeforePenny");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InsertAndBeforePenny;
        partial void OnInsertAndBeforePennyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInsertAndBeforePennyChanged();
        /// <summary>
        /// There are no comments for Property NameForFive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameForFive")]
        public virtual string NameForFive
        {
            get
            {
                return this._NameForFive;
            }
            set
            {
                this.OnNameForFiveChanging(value);
                this._NameForFive = value;
                this.OnNameForFiveChanged();
                this.OnPropertyChanged("NameForFive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameForFive;
        partial void OnNameForFiveChanging(string value);
        partial void OnNameForFiveChanged();
        /// <summary>
        /// There are no comments for Property NameForFivePenny in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameForFivePenny")]
        public virtual string NameForFivePenny
        {
            get
            {
                return this._NameForFivePenny;
            }
            set
            {
                this.OnNameForFivePennyChanging(value);
                this._NameForFivePenny = value;
                this.OnNameForFivePennyChanged();
                this.OnPropertyChanged("NameForFivePenny");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameForFivePenny;
        partial void OnNameForFivePennyChanging(string value);
        partial void OnNameForFivePennyChanged();
        /// <summary>
        /// There are no comments for Property CurrencyPluralNominative in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyPluralNominative")]
        public virtual string CurrencyPluralNominative
        {
            get
            {
                return this._CurrencyPluralNominative;
            }
            set
            {
                this.OnCurrencyPluralNominativeChanging(value);
                this._CurrencyPluralNominative = value;
                this.OnCurrencyPluralNominativeChanged();
                this.OnPropertyChanged("CurrencyPluralNominative");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyPluralNominative;
        partial void OnCurrencyPluralNominativeChanging(string value);
        partial void OnCurrencyPluralNominativeChanged();
        /// <summary>
        /// There are no comments for Property NameForOnePenny in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameForOnePenny")]
        public virtual string NameForOnePenny
        {
            get
            {
                return this._NameForOnePenny;
            }
            set
            {
                this.OnNameForOnePennyChanging(value);
                this._NameForOnePenny = value;
                this.OnNameForOnePennyChanged();
                this.OnPropertyChanged("NameForOnePenny");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameForOnePenny;
        partial void OnNameForOnePennyChanging(string value);
        partial void OnNameForOnePennyChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShortName")]
        public virtual string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property NameForThree in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameForThree")]
        public virtual string NameForThree
        {
            get
            {
                return this._NameForThree;
            }
            set
            {
                this.OnNameForThreeChanging(value);
                this._NameForThree = value;
                this.OnNameForThreeChanged();
                this.OnPropertyChanged("NameForThree");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameForThree;
        partial void OnNameForThreeChanging(string value);
        partial void OnNameForThreeChanged();
        /// <summary>
        /// There are no comments for Property NameForThreePenny in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameForThreePenny")]
        public virtual string NameForThreePenny
        {
            get
            {
                return this._NameForThreePenny;
            }
            set
            {
                this.OnNameForThreePennyChanging(value);
                this._NameForThreePenny = value;
                this.OnNameForThreePennyChanged();
                this.OnPropertyChanged("NameForThreePenny");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameForThreePenny;
        partial void OnNameForThreePennyChanging(string value);
        partial void OnNameForThreePennyChanged();
        /// <summary>
        /// There are no comments for Property ShortNamePenny in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShortNamePenny")]
        public virtual string ShortNamePenny
        {
            get
            {
                return this._ShortNamePenny;
            }
            set
            {
                this.OnShortNamePennyChanging(value);
                this._ShortNamePenny = value;
                this.OnShortNamePennyChanged();
                this.OnPropertyChanged("ShortNamePenny");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortNamePenny;
        partial void OnShortNamePennyChanging(string value);
        partial void OnShortNamePennyChanged();
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
