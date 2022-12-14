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
    /// There are no comments for AutoTaxHeaderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AutoTaxHeaderSingle")]
    public partial class AutoTaxHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AutoTaxHeader>
    {
        /// <summary>
        /// Initialize a new AutoTaxHeaderSingle object.
        /// </summary>
        public AutoTaxHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AutoTaxHeaderSingle object.
        /// </summary>
        public AutoTaxHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AutoTaxHeaderSingle object.
        /// </summary>
        public AutoTaxHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AutoTaxHeader> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AutoTaxHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("AutoTaxHeaders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AutoTaxHeader")]
    public partial class AutoTaxHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AutoTaxHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AutoTaxHeader CreateAutoTaxHeader(string dataAreaId)
        {
            AutoTaxHeader autoTaxHeader = new AutoTaxHeader();
            autoTaxHeader.DataAreaId = dataAreaId;
            return autoTaxHeader;
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
        /// There are no comments for Property Warnings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Warnings")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Warnings
        {
            get
            {
                return this._Warnings;
            }
            set
            {
                this.OnWarningsChanging(value);
                this._Warnings = value;
                this.OnWarningsChanged();
                this.OnPropertyChanged("Warnings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Warnings;
        partial void OnWarningsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWarningsChanged();
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
