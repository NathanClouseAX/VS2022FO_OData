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
    /// There are no comments for Kitting_DynamicKitSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Kitting_DynamicKitSingle")]
    public partial class Kitting_DynamicKitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_DynamicKit>
    {
        /// <summary>
        /// Initialize a new Kitting_DynamicKitSingle object.
        /// </summary>
        public Kitting_DynamicKitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new Kitting_DynamicKitSingle object.
        /// </summary>
        public Kitting_DynamicKitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new Kitting_DynamicKitSingle object.
        /// </summary>
        public Kitting_DynamicKitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_DynamicKit> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Kitting_DynamicKit in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DynamicKitId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DynamicKitId")]
    [global::Microsoft.OData.Client.EntitySet("Kitting_DynamicKits")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Kitting_DynamicKit")]
    public partial class Kitting_DynamicKit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Kitting_DynamicKit object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="dynamicKitId">Initial value of DynamicKitId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Kitting_DynamicKit CreateKitting_DynamicKit(string dataAreaId, string dynamicKitId)
        {
            Kitting_DynamicKit kitting_DynamicKit = new Kitting_DynamicKit();
            kitting_DynamicKit.DataAreaId = dataAreaId;
            kitting_DynamicKit.DynamicKitId = dynamicKitId;
            return kitting_DynamicKit;
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
        /// There are no comments for Property DynamicKitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DynamicKitId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DynamicKitId is required.")]
        public virtual string DynamicKitId
        {
            get
            {
                return this._DynamicKitId;
            }
            set
            {
                this.OnDynamicKitIdChanging(value);
                this._DynamicKitId = value;
                this.OnDynamicKitIdChanged();
                this.OnPropertyChanged("DynamicKitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicKitId;
        partial void OnDynamicKitIdChanging(string value);
        partial void OnDynamicKitIdChanged();
        /// <summary>
        /// There are no comments for Property DynamicKitName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DynamicKitName")]
        public virtual string DynamicKitName
        {
            get
            {
                return this._DynamicKitName;
            }
            set
            {
                this.OnDynamicKitNameChanging(value);
                this._DynamicKitName = value;
                this.OnDynamicKitNameChanged();
                this.OnPropertyChanged("DynamicKitName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicKitName;
        partial void OnDynamicKitNameChanging(string value);
        partial void OnDynamicKitNameChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApproverPersonnelNumber")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsApproved")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property SiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SiteId")]
        public virtual string SiteId
        {
            get
            {
                return this._SiteId;
            }
            set
            {
                this.OnSiteIdChanging(value);
                this._SiteId = value;
                this.OnSiteIdChanged();
                this.OnPropertyChanged("SiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SiteId;
        partial void OnSiteIdChanging(string value);
        partial void OnSiteIdChanged();
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
