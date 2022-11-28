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
    /// There are no comments for VendorPaymentInterestCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentInterestCodeSingle")]
    public partial class VendorPaymentInterestCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentInterestCode>
    {
        /// <summary>
        /// Initialize a new VendorPaymentInterestCodeSingle object.
        /// </summary>
        public VendorPaymentInterestCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorPaymentInterestCodeSingle object.
        /// </summary>
        public VendorPaymentInterestCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorPaymentInterestCodeSingle object.
        /// </summary>
        public VendorPaymentInterestCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentInterestCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VendorPaymentInterestCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// InterestCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "InterestCode")]
    [global::Microsoft.OData.Client.EntitySet("VendorPaymentInterestCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentInterestCode")]
    public partial class VendorPaymentInterestCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorPaymentInterestCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="interestCode">Initial value of InterestCode.</param>
        /// <param name="gracePeriodDays">Initial value of GracePeriodDays.</param>
        /// <param name="interestCalculationPer">Initial value of InterestCalculationPer.</param>
        /// <param name="interestPercentage">Initial value of InterestPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorPaymentInterestCode CreateVendorPaymentInterestCode(string dataAreaId, string interestCode, int gracePeriodDays, int interestCalculationPer, decimal interestPercentage)
        {
            VendorPaymentInterestCode vendorPaymentInterestCode = new VendorPaymentInterestCode();
            vendorPaymentInterestCode.DataAreaId = dataAreaId;
            vendorPaymentInterestCode.InterestCode = interestCode;
            vendorPaymentInterestCode.GracePeriodDays = gracePeriodDays;
            vendorPaymentInterestCode.InterestCalculationPer = interestCalculationPer;
            vendorPaymentInterestCode.InterestPercentage = interestPercentage;
            return vendorPaymentInterestCode;
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
        /// There are no comments for Property InterestCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InterestCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InterestCode is required.")]
        public virtual string InterestCode
        {
            get
            {
                return this._InterestCode;
            }
            set
            {
                this.OnInterestCodeChanging(value);
                this._InterestCode = value;
                this.OnInterestCodeChanged();
                this.OnPropertyChanged("InterestCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InterestCode;
        partial void OnInterestCodeChanging(string value);
        partial void OnInterestCodeChanged();
        /// <summary>
        /// There are no comments for Property DayOrMonth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DayOrMonth")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayMonth> DayOrMonth
        {
            get
            {
                return this._DayOrMonth;
            }
            set
            {
                this.OnDayOrMonthChanging(value);
                this._DayOrMonth = value;
                this.OnDayOrMonthChanged();
                this.OnPropertyChanged("DayOrMonth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayMonth> _DayOrMonth;
        partial void OnDayOrMonthChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DayMonth> value);
        partial void OnDayOrMonthChanged();
        /// <summary>
        /// There are no comments for Property GracePeriodDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GracePeriodDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GracePeriodDays is required.")]
        public virtual int GracePeriodDays
        {
            get
            {
                return this._GracePeriodDays;
            }
            set
            {
                this.OnGracePeriodDaysChanging(value);
                this._GracePeriodDays = value;
                this.OnGracePeriodDaysChanged();
                this.OnPropertyChanged("GracePeriodDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _GracePeriodDays;
        partial void OnGracePeriodDaysChanging(int value);
        partial void OnGracePeriodDaysChanged();
        /// <summary>
        /// There are no comments for Property InterestCalculationPer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InterestCalculationPer")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InterestCalculationPer is required.")]
        public virtual int InterestCalculationPer
        {
            get
            {
                return this._InterestCalculationPer;
            }
            set
            {
                this.OnInterestCalculationPerChanging(value);
                this._InterestCalculationPer = value;
                this.OnInterestCalculationPerChanged();
                this.OnPropertyChanged("InterestCalculationPer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _InterestCalculationPer;
        partial void OnInterestCalculationPerChanging(int value);
        partial void OnInterestCalculationPerChanged();
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
        /// There are no comments for Property InterestPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InterestPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InterestPercentage is required.")]
        public virtual decimal InterestPercentage
        {
            get
            {
                return this._InterestPercentage;
            }
            set
            {
                this.OnInterestPercentageChanging(value);
                this._InterestPercentage = value;
                this.OnInterestPercentageChanged();
                this.OnPropertyChanged("InterestPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InterestPercentage;
        partial void OnInterestPercentageChanging(decimal value);
        partial void OnInterestPercentageChanged();
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
