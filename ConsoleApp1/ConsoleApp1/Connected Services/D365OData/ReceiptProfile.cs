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
    /// There are no comments for ReceiptProfileSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptProfileSingle")]
    public partial class ReceiptProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReceiptProfile>
    {
        /// <summary>
        /// Initialize a new ReceiptProfileSingle object.
        /// </summary>
        public ReceiptProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReceiptProfileSingle object.
        /// </summary>
        public ReceiptProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReceiptProfileSingle object.
        /// </summary>
        public ReceiptProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReceiptProfile> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ReceiptProfile in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProfileId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProfileId")]
    [global::Microsoft.OData.Client.EntitySet("ReceiptProfiles")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptProfile")]
    public partial class ReceiptProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReceiptProfile object.
        /// </summary>
        /// <param name="profileId">Initial value of ProfileId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReceiptProfile CreateReceiptProfile(string profileId)
        {
            ReceiptProfile receiptProfile = new ReceiptProfile();
            receiptProfile.ProfileId = profileId;
            return receiptProfile;
        }
        /// <summary>
        /// There are no comments for Property ProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProfileId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProfileId is required.")]
        public virtual string ProfileId
        {
            get
            {
                return this._ProfileId;
            }
            set
            {
                this.OnProfileIdChanging(value);
                this._ProfileId = value;
                this.OnProfileIdChanged();
                this.OnPropertyChanged("ProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProfileId;
        partial void OnProfileIdChanging(string value);
        partial void OnProfileIdChanged();
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