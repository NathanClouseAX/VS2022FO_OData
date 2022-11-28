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
    /// There are no comments for ProjCFDANumberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCFDANumberSingle")]
    public partial class ProjCFDANumberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjCFDANumber>
    {
        /// <summary>
        /// Initialize a new ProjCFDANumberSingle object.
        /// </summary>
        public ProjCFDANumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjCFDANumberSingle object.
        /// </summary>
        public ProjCFDANumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjCFDANumberSingle object.
        /// </summary>
        public ProjCFDANumberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjCFDANumber> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ProjCFDANumber in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// CFDAID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CFDAID")]
    [global::Microsoft.OData.Client.EntitySet("ProjCFDANumbers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProjCFDANumber")]
    public partial class ProjCFDANumber : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjCFDANumber object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="cFDAID">Initial value of CFDAID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjCFDANumber CreateProjCFDANumber(string dataAreaId, string cFDAID)
        {
            ProjCFDANumber projCFDANumber = new ProjCFDANumber();
            projCFDANumber.DataAreaId = dataAreaId;
            projCFDANumber.CFDAID = cFDAID;
            return projCFDANumber;
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
        /// There are no comments for Property CFDAID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFDAID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CFDAID is required.")]
        public virtual string CFDAID
        {
            get
            {
                return this._CFDAID;
            }
            set
            {
                this.OnCFDAIDChanging(value);
                this._CFDAID = value;
                this.OnCFDAIDChanged();
                this.OnPropertyChanged("CFDAID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFDAID;
        partial void OnCFDAIDChanging(string value);
        partial void OnCFDAIDChanged();
        /// <summary>
        /// There are no comments for Property CFDAClusterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFDAClusterName")]
        public virtual string CFDAClusterName
        {
            get
            {
                return this._CFDAClusterName;
            }
            set
            {
                this.OnCFDAClusterNameChanging(value);
                this._CFDAClusterName = value;
                this.OnCFDAClusterNameChanged();
                this.OnPropertyChanged("CFDAClusterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFDAClusterName;
        partial void OnCFDAClusterNameChanging(string value);
        partial void OnCFDAClusterNameChanged();
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
