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
    /// There are no comments for RetailMixAndMatchLineGroupSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailMixAndMatchLineGroupSetupSingle")]
    public partial class RetailMixAndMatchLineGroupSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailMixAndMatchLineGroupSetup>
    {
        /// <summary>
        /// Initialize a new RetailMixAndMatchLineGroupSetupSingle object.
        /// </summary>
        public RetailMixAndMatchLineGroupSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailMixAndMatchLineGroupSetupSingle object.
        /// </summary>
        public RetailMixAndMatchLineGroupSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailMixAndMatchLineGroupSetupSingle object.
        /// </summary>
        public RetailMixAndMatchLineGroupSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailMixAndMatchLineGroupSetup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RetailMixAndMatchLineGroupSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// MixAndMatchLineGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "mixAndMatchLineGroup")]
    [global::Microsoft.OData.Client.EntitySet("RetailMixAndMatchLineGroupSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RetailMixAndMatchLineGroupSetup")]
    public partial class RetailMixAndMatchLineGroupSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailMixAndMatchLineGroupSetup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="mixAndMatchLineGroup">Initial value of MixAndMatchLineGroup.</param>
        /// <param name="discountLineColorId">Initial value of DiscountLineColorId.</param>
        /// <param name="numberOfItemsNeeded">Initial value of NumberOfItemsNeeded.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailMixAndMatchLineGroupSetup CreateRetailMixAndMatchLineGroupSetup(string dataAreaId, string mixAndMatchLineGroup, int discountLineColorId, int numberOfItemsNeeded)
        {
            RetailMixAndMatchLineGroupSetup retailMixAndMatchLineGroupSetup = new RetailMixAndMatchLineGroupSetup();
            retailMixAndMatchLineGroupSetup.DataAreaId = dataAreaId;
            retailMixAndMatchLineGroupSetup.MixAndMatchLineGroup = mixAndMatchLineGroup;
            retailMixAndMatchLineGroupSetup.DiscountLineColorId = discountLineColorId;
            retailMixAndMatchLineGroupSetup.NumberOfItemsNeeded = numberOfItemsNeeded;
            return retailMixAndMatchLineGroupSetup;
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
        /// There are no comments for Property MixAndMatchLineGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("mixAndMatchLineGroup")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MixAndMatchLineGroup is required.")]
        public virtual string MixAndMatchLineGroup
        {
            get
            {
                return this._MixAndMatchLineGroup;
            }
            set
            {
                this.OnMixAndMatchLineGroupChanging(value);
                this._MixAndMatchLineGroup = value;
                this.OnMixAndMatchLineGroupChanged();
                this.OnPropertyChanged("mixAndMatchLineGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MixAndMatchLineGroup;
        partial void OnMixAndMatchLineGroupChanging(string value);
        partial void OnMixAndMatchLineGroupChanged();
        /// <summary>
        /// There are no comments for Property DiscountLineColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("discountLineColorId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountLineColorId is required.")]
        public virtual int DiscountLineColorId
        {
            get
            {
                return this._DiscountLineColorId;
            }
            set
            {
                this.OnDiscountLineColorIdChanging(value);
                this._DiscountLineColorId = value;
                this.OnDiscountLineColorIdChanged();
                this.OnPropertyChanged("discountLineColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DiscountLineColorId;
        partial void OnDiscountLineColorIdChanging(int value);
        partial void OnDiscountLineColorIdChanged();
        /// <summary>
        /// There are no comments for Property NumberOfItemsNeeded in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("numberOfItemsNeeded")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "NumberOfItemsNeeded is required.")]
        public virtual int NumberOfItemsNeeded
        {
            get
            {
                return this._NumberOfItemsNeeded;
            }
            set
            {
                this.OnNumberOfItemsNeededChanging(value);
                this._NumberOfItemsNeeded = value;
                this.OnNumberOfItemsNeededChanged();
                this.OnPropertyChanged("numberOfItemsNeeded");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _NumberOfItemsNeeded;
        partial void OnNumberOfItemsNeededChanging(int value);
        partial void OnNumberOfItemsNeededChanged();
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