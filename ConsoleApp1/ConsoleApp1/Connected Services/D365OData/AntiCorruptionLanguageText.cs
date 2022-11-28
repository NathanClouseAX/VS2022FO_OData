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
    /// There are no comments for AntiCorruptionLanguageTextSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AntiCorruptionLanguageTextSingle")]
    public partial class AntiCorruptionLanguageTextSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AntiCorruptionLanguageText>
    {
        /// <summary>
        /// Initialize a new AntiCorruptionLanguageTextSingle object.
        /// </summary>
        public AntiCorruptionLanguageTextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AntiCorruptionLanguageTextSingle object.
        /// </summary>
        public AntiCorruptionLanguageTextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AntiCorruptionLanguageTextSingle object.
        /// </summary>
        public AntiCorruptionLanguageTextSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AntiCorruptionLanguageText> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AntiCorruptionLanguageText in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// LanguageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LanguageId")]
    [global::Microsoft.OData.Client.EntitySet("AntiCorruptionLanguageTexts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AntiCorruptionLanguageText")]
    public partial class AntiCorruptionLanguageText : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AntiCorruptionLanguageText object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AntiCorruptionLanguageText CreateAntiCorruptionLanguageText(string dataAreaId, string languageId)
        {
            AntiCorruptionLanguageText antiCorruptionLanguageText = new AntiCorruptionLanguageText();
            antiCorruptionLanguageText.DataAreaId = dataAreaId;
            antiCorruptionLanguageText.LanguageId = languageId;
            return antiCorruptionLanguageText;
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
        /// There are no comments for Property ApproverMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproverMessage")]
        public virtual string ApproverMessage
        {
            get
            {
                return this._ApproverMessage;
            }
            set
            {
                this.OnApproverMessageChanging(value);
                this._ApproverMessage = value;
                this.OnApproverMessageChanged();
                this.OnPropertyChanged("ApproverMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverMessage;
        partial void OnApproverMessageChanging(string value);
        partial void OnApproverMessageChanged();
        /// <summary>
        /// There are no comments for Property AttestationMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttestationMessage")]
        public virtual string AttestationMessage
        {
            get
            {
                return this._AttestationMessage;
            }
            set
            {
                this.OnAttestationMessageChanging(value);
                this._AttestationMessage = value;
                this.OnAttestationMessageChanged();
                this.OnPropertyChanged("AttestationMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttestationMessage;
        partial void OnAttestationMessageChanging(string value);
        partial void OnAttestationMessageChanged();
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
