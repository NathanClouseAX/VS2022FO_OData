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
    /// There are no comments for PWPVendorRetentionSettingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PWPVendorRetentionSettingSingle")]
    public partial class PWPVendorRetentionSettingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PWPVendorRetentionSetting>
    {
        /// <summary>
        /// Initialize a new PWPVendorRetentionSettingSingle object.
        /// </summary>
        public PWPVendorRetentionSettingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PWPVendorRetentionSettingSingle object.
        /// </summary>
        public PWPVendorRetentionSettingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PWPVendorRetentionSettingSingle object.
        /// </summary>
        public PWPVendorRetentionSettingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PWPVendorRetentionSetting> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PWPVendorRetentionSetting in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ProjId
    /// VendorId
    /// VendorGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProjId", "VendorId", "VendorGroup")]
    [global::Microsoft.OData.Client.EntitySet("PWPVendorRetentionSettings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PWPVendorRetentionSetting")]
    public partial class PWPVendorRetentionSetting : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PWPVendorRetentionSetting object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="projId">Initial value of ProjId.</param>
        /// <param name="vendorId">Initial value of VendorId.</param>
        /// <param name="vendorGroup">Initial value of VendorGroup.</param>
        /// <param name="pwpThresholdPercent">Initial value of PwpThresholdPercent.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PWPVendorRetentionSetting CreatePWPVendorRetentionSetting(string dataAreaId, string projId, string vendorId, string vendorGroup, decimal pwpThresholdPercent)
        {
            PWPVendorRetentionSetting pWPVendorRetentionSetting = new PWPVendorRetentionSetting();
            pWPVendorRetentionSetting.DataAreaId = dataAreaId;
            pWPVendorRetentionSetting.ProjId = projId;
            pWPVendorRetentionSetting.VendorId = vendorId;
            pWPVendorRetentionSetting.VendorGroup = vendorGroup;
            pWPVendorRetentionSetting.PwpThresholdPercent = pwpThresholdPercent;
            return pWPVendorRetentionSetting;
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
        /// There are no comments for Property ProjId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProjId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProjId is required.")]
        public virtual string ProjId
        {
            get
            {
                return this._ProjId;
            }
            set
            {
                this.OnProjIdChanging(value);
                this._ProjId = value;
                this.OnProjIdChanged();
                this.OnPropertyChanged("ProjId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjId;
        partial void OnProjIdChanging(string value);
        partial void OnProjIdChanged();
        /// <summary>
        /// There are no comments for Property VendorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VendorId is required.")]
        public virtual string VendorId
        {
            get
            {
                return this._VendorId;
            }
            set
            {
                this.OnVendorIdChanging(value);
                this._VendorId = value;
                this.OnVendorIdChanged();
                this.OnPropertyChanged("VendorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorId;
        partial void OnVendorIdChanging(string value);
        partial void OnVendorIdChanged();
        /// <summary>
        /// There are no comments for Property VendorGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VendorGroup is required.")]
        public virtual string VendorGroup
        {
            get
            {
                return this._VendorGroup;
            }
            set
            {
                this.OnVendorGroupChanging(value);
                this._VendorGroup = value;
                this.OnVendorGroupChanged();
                this.OnPropertyChanged("VendorGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorGroup;
        partial void OnVendorGroupChanging(string value);
        partial void OnVendorGroupChanged();
        /// <summary>
        /// There are no comments for Property RuleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleId")]
        public virtual string RuleId
        {
            get
            {
                return this._RuleId;
            }
            set
            {
                this.OnRuleIdChanging(value);
                this._RuleId = value;
                this.OnRuleIdChanged();
                this.OnPropertyChanged("RuleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleId;
        partial void OnRuleIdChanging(string value);
        partial void OnRuleIdChanged();
        /// <summary>
        /// There are no comments for Property PwpThresholdPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PwpThresholdPercent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PwpThresholdPercent is required.")]
        public virtual decimal PwpThresholdPercent
        {
            get
            {
                return this._PwpThresholdPercent;
            }
            set
            {
                this.OnPwpThresholdPercentChanging(value);
                this._PwpThresholdPercent = value;
                this.OnPwpThresholdPercentChanged();
                this.OnPropertyChanged("PwpThresholdPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PwpThresholdPercent;
        partial void OnPwpThresholdPercentChanging(decimal value);
        partial void OnPwpThresholdPercentChanged();
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
