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
    /// There are no comments for HSNCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("HSNCodeSingle")]
    public partial class HSNCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<HSNCode>
    {
        /// <summary>
        /// Initialize a new HSNCodeSingle object.
        /// </summary>
        public HSNCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new HSNCodeSingle object.
        /// </summary>
        public HSNCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new HSNCodeSingle object.
        /// </summary>
        public HSNCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<HSNCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for HSNCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Chapter
    /// Heading
    /// Subheading
    /// CountryExtension
    /// StatisticalSuffix
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Chapter", "Heading", "Subheading", "CountryExtension", "StatisticalSuffix")]
    [global::Microsoft.OData.Client.EntitySet("HSNCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("HSNCode")]
    public partial class HSNCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new HSNCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="chapter">Initial value of Chapter.</param>
        /// <param name="heading">Initial value of Heading.</param>
        /// <param name="subheading">Initial value of Subheading.</param>
        /// <param name="countryExtension">Initial value of CountryExtension.</param>
        /// <param name="statisticalSuffix">Initial value of StatisticalSuffix.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static HSNCode CreateHSNCode(string dataAreaId, 
                    string chapter, 
                    string heading, 
                    string subheading, 
                    string countryExtension, 
                    string statisticalSuffix)
        {
            HSNCode hSNCode = new HSNCode();
            hSNCode.DataAreaId = dataAreaId;
            hSNCode.Chapter = chapter;
            hSNCode.Heading = heading;
            hSNCode.Subheading = subheading;
            hSNCode.CountryExtension = countryExtension;
            hSNCode.StatisticalSuffix = statisticalSuffix;
            return hSNCode;
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
        /// There are no comments for Property Chapter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Chapter")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Chapter is required.")]
        public virtual string Chapter
        {
            get
            {
                return this._Chapter;
            }
            set
            {
                this.OnChapterChanging(value);
                this._Chapter = value;
                this.OnChapterChanged();
                this.OnPropertyChanged("Chapter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Chapter;
        partial void OnChapterChanging(string value);
        partial void OnChapterChanged();
        /// <summary>
        /// There are no comments for Property Heading in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Heading")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Heading is required.")]
        public virtual string Heading
        {
            get
            {
                return this._Heading;
            }
            set
            {
                this.OnHeadingChanging(value);
                this._Heading = value;
                this.OnHeadingChanged();
                this.OnPropertyChanged("Heading");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Heading;
        partial void OnHeadingChanging(string value);
        partial void OnHeadingChanged();
        /// <summary>
        /// There are no comments for Property Subheading in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Subheading")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Subheading is required.")]
        public virtual string Subheading
        {
            get
            {
                return this._Subheading;
            }
            set
            {
                this.OnSubheadingChanging(value);
                this._Subheading = value;
                this.OnSubheadingChanged();
                this.OnPropertyChanged("Subheading");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Subheading;
        partial void OnSubheadingChanging(string value);
        partial void OnSubheadingChanged();
        /// <summary>
        /// There are no comments for Property CountryExtension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryExtension")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CountryExtension is required.")]
        public virtual string CountryExtension
        {
            get
            {
                return this._CountryExtension;
            }
            set
            {
                this.OnCountryExtensionChanging(value);
                this._CountryExtension = value;
                this.OnCountryExtensionChanged();
                this.OnPropertyChanged("CountryExtension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryExtension;
        partial void OnCountryExtensionChanging(string value);
        partial void OnCountryExtensionChanged();
        /// <summary>
        /// There are no comments for Property StatisticalSuffix in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatisticalSuffix")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StatisticalSuffix is required.")]
        public virtual string StatisticalSuffix
        {
            get
            {
                return this._StatisticalSuffix;
            }
            set
            {
                this.OnStatisticalSuffixChanging(value);
                this._StatisticalSuffix = value;
                this.OnStatisticalSuffixChanged();
                this.OnPropertyChanged("StatisticalSuffix");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatisticalSuffix;
        partial void OnStatisticalSuffixChanging(string value);
        partial void OnStatisticalSuffixChanged();
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
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