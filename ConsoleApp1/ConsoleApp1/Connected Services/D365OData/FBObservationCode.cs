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
    /// There are no comments for FBObservationCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FBObservationCodeSingle")]
    public partial class FBObservationCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FBObservationCode>
    {
        /// <summary>
        /// Initialize a new FBObservationCodeSingle object.
        /// </summary>
        public FBObservationCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FBObservationCodeSingle object.
        /// </summary>
        public FBObservationCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FBObservationCodeSingle object.
        /// </summary>
        public FBObservationCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FBObservationCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FBObservationCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ObservationCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ObservationCode")]
    [global::Microsoft.OData.Client.EntitySet("FBObservationCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FBObservationCode")]
    public partial class FBObservationCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FBObservationCode object.
        /// </summary>
        /// <param name="observationCode">Initial value of ObservationCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FBObservationCode CreateFBObservationCode(string observationCode)
        {
            FBObservationCode fBObservationCode = new FBObservationCode();
            fBObservationCode.ObservationCode = observationCode;
            return fBObservationCode;
        }
        /// <summary>
        /// There are no comments for Property ObservationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObservationCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ObservationCode is required.")]
        public virtual string ObservationCode
        {
            get
            {
                return this._ObservationCode;
            }
            set
            {
                this.OnObservationCodeChanging(value);
                this._ObservationCode = value;
                this.OnObservationCodeChanged();
                this.OnPropertyChanged("ObservationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObservationCode;
        partial void OnObservationCodeChanging(string value);
        partial void OnObservationCodeChanged();
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
