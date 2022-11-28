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
    /// There are no comments for VendorRetentionTermScheduleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRetentionTermScheduleSingle")]
    public partial class VendorRetentionTermScheduleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRetentionTermSchedule>
    {
        /// <summary>
        /// Initialize a new VendorRetentionTermScheduleSingle object.
        /// </summary>
        public VendorRetentionTermScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorRetentionTermScheduleSingle object.
        /// </summary>
        public VendorRetentionTermScheduleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorRetentionTermScheduleSingle object.
        /// </summary>
        public VendorRetentionTermScheduleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRetentionTermSchedule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorRetentionTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRetentionTerm")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorRetentionTermSingle VendorRetentionTerm
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorRetentionTerm == null))
                {
                    this._VendorRetentionTerm = new global::Microsoft.Dynamics.DataEntities.VendorRetentionTermSingle(this.Context, GetPath("VendorRetentionTerm"));
                }
                return this._VendorRetentionTerm;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorRetentionTermSingle _VendorRetentionTerm;
    }
    /// <summary>
    /// There are no comments for VendorRetentionTermSchedule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// RuleID
    /// PercentageOfUnitsDelivered
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RuleID", "PercentageOfUnitsDelivered")]
    [global::Microsoft.OData.Client.EntitySet("VendorRetentionTermSchedules")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRetentionTermSchedule")]
    public partial class VendorRetentionTermSchedule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorRetentionTermSchedule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="ruleID">Initial value of RuleID.</param>
        /// <param name="percentageOfUnitsDelivered">Initial value of PercentageOfUnitsDelivered.</param>
        /// <param name="percentageToRetain">Initial value of PercentageToRetain.</param>
        /// <param name="percentageToRelease">Initial value of PercentageToRelease.</param>
        /// <param name="vendorRetentionTerm">Initial value of VendorRetentionTerm.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorRetentionTermSchedule CreateVendorRetentionTermSchedule(string dataAreaId, 
                    string ruleID, 
                    decimal percentageOfUnitsDelivered, 
                    decimal percentageToRetain, 
                    decimal percentageToRelease, 
                    global::Microsoft.Dynamics.DataEntities.VendorRetentionTerm vendorRetentionTerm)
        {
            VendorRetentionTermSchedule vendorRetentionTermSchedule = new VendorRetentionTermSchedule();
            vendorRetentionTermSchedule.DataAreaId = dataAreaId;
            vendorRetentionTermSchedule.RuleID = ruleID;
            vendorRetentionTermSchedule.PercentageOfUnitsDelivered = percentageOfUnitsDelivered;
            vendorRetentionTermSchedule.PercentageToRetain = percentageToRetain;
            vendorRetentionTermSchedule.PercentageToRelease = percentageToRelease;
            if ((vendorRetentionTerm == null))
            {
                throw new global::System.ArgumentNullException("vendorRetentionTerm");
            }
            vendorRetentionTermSchedule.VendorRetentionTerm = vendorRetentionTerm;
            return vendorRetentionTermSchedule;
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
        /// There are no comments for Property RuleID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RuleID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RuleID is required.")]
        public virtual string RuleID
        {
            get
            {
                return this._RuleID;
            }
            set
            {
                this.OnRuleIDChanging(value);
                this._RuleID = value;
                this.OnRuleIDChanged();
                this.OnPropertyChanged("RuleID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleID;
        partial void OnRuleIDChanging(string value);
        partial void OnRuleIDChanged();
        /// <summary>
        /// There are no comments for Property PercentageOfUnitsDelivered in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PercentageOfUnitsDelivered")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PercentageOfUnitsDelivered is required.")]
        public virtual decimal PercentageOfUnitsDelivered
        {
            get
            {
                return this._PercentageOfUnitsDelivered;
            }
            set
            {
                this.OnPercentageOfUnitsDeliveredChanging(value);
                this._PercentageOfUnitsDelivered = value;
                this.OnPercentageOfUnitsDeliveredChanged();
                this.OnPropertyChanged("PercentageOfUnitsDelivered");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentageOfUnitsDelivered;
        partial void OnPercentageOfUnitsDeliveredChanging(decimal value);
        partial void OnPercentageOfUnitsDeliveredChanged();
        /// <summary>
        /// There are no comments for Property PercentageToRetain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PercentageToRetain")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PercentageToRetain is required.")]
        public virtual decimal PercentageToRetain
        {
            get
            {
                return this._PercentageToRetain;
            }
            set
            {
                this.OnPercentageToRetainChanging(value);
                this._PercentageToRetain = value;
                this.OnPercentageToRetainChanged();
                this.OnPropertyChanged("PercentageToRetain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentageToRetain;
        partial void OnPercentageToRetainChanging(decimal value);
        partial void OnPercentageToRetainChanged();
        /// <summary>
        /// There are no comments for Property PercentageToRelease in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PercentageToRelease")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PercentageToRelease is required.")]
        public virtual decimal PercentageToRelease
        {
            get
            {
                return this._PercentageToRelease;
            }
            set
            {
                this.OnPercentageToReleaseChanging(value);
                this._PercentageToRelease = value;
                this.OnPercentageToReleaseChanged();
                this.OnPropertyChanged("PercentageToRelease");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentageToRelease;
        partial void OnPercentageToReleaseChanging(decimal value);
        partial void OnPercentageToReleaseChanged();
        /// <summary>
        /// There are no comments for Property VendorRetentionTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRetentionTerm")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VendorRetentionTerm is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorRetentionTerm VendorRetentionTerm
        {
            get
            {
                return this._VendorRetentionTerm;
            }
            set
            {
                this.OnVendorRetentionTermChanging(value);
                this._VendorRetentionTerm = value;
                this.OnVendorRetentionTermChanged();
                this.OnPropertyChanged("VendorRetentionTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorRetentionTerm _VendorRetentionTerm;
        partial void OnVendorRetentionTermChanging(global::Microsoft.Dynamics.DataEntities.VendorRetentionTerm value);
        partial void OnVendorRetentionTermChanged();
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
