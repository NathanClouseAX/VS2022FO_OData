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
    /// There are no comments for TaxExemptCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxExemptCodeSingle")]
    public partial class TaxExemptCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxExemptCode>
    {
        /// <summary>
        /// Initialize a new TaxExemptCodeSingle object.
        /// </summary>
        public TaxExemptCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxExemptCodeSingle object.
        /// </summary>
        public TaxExemptCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxExemptCodeSingle object.
        /// </summary>
        public TaxExemptCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxExemptCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxGroupData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroupData")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TaxGroupData> TaxGroupData
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxGroupData == null))
                {
                    this._TaxGroupData = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TaxGroupData>(GetPath("TaxGroupData"));
                }
                return this._TaxGroupData;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TaxGroupData> _TaxGroupData;
    }
    /// <summary>
    /// There are no comments for TaxExemptCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TaxExemptCode
    /// Language
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxExemptCode", "Language")]
    [global::Microsoft.OData.Client.EntitySet("TaxExemptCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxExemptCode")]
    public partial class TaxExemptCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxExemptCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="taxExemptCode1">Initial value of TaxExemptCode1.</param>
        /// <param name="language">Initial value of Language.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxExemptCode CreateTaxExemptCode(string dataAreaId, string taxExemptCode1, string language)
        {
            TaxExemptCode taxExemptCode = new TaxExemptCode();
            taxExemptCode.DataAreaId = dataAreaId;
            taxExemptCode.TaxExemptCode1 = taxExemptCode1;
            taxExemptCode.Language = language;
            return taxExemptCode;
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
        /// There are no comments for Property TaxExemptCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxExemptCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxExemptCode1 is required.")]
        public virtual string TaxExemptCode1
        {
            get
            {
                return this._TaxExemptCode1;
            }
            set
            {
                this.OnTaxExemptCode1Changing(value);
                this._TaxExemptCode1 = value;
                this.OnTaxExemptCode1Changed();
                this.OnPropertyChanged("TaxExemptCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxExemptCode1;
        partial void OnTaxExemptCode1Changing(string value);
        partial void OnTaxExemptCode1Changed();
        /// <summary>
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Language")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Language is required.")]
        public virtual string Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Language;
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
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
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text")]
        public virtual string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this._Text = value;
                this.OnTextChanged();
                this.OnPropertyChanged("Text");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
        /// <summary>
        /// There are no comments for Property TaxGroupData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxGroupData")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxGroupData> TaxGroupData
        {
            get
            {
                return this._TaxGroupData;
            }
            set
            {
                this.OnTaxGroupDataChanging(value);
                this._TaxGroupData = value;
                this.OnTaxGroupDataChanged();
                this.OnPropertyChanged("TaxGroupData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxGroupData> _TaxGroupData = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxGroupData>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTaxGroupDataChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TaxGroupData> value);
        partial void OnTaxGroupDataChanged();
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
