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
    /// There are no comments for VendorPaymentFineCodeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentFineCodeSingle")]
    public partial class VendorPaymentFineCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentFineCode>
    {
        /// <summary>
        /// Initialize a new VendorPaymentFineCodeSingle object.
        /// </summary>
        public VendorPaymentFineCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorPaymentFineCodeSingle object.
        /// </summary>
        public VendorPaymentFineCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorPaymentFineCodeSingle object.
        /// </summary>
        public VendorPaymentFineCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentFineCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VendorPaymentFineCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// FineCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FineCode")]
    [global::Microsoft.OData.Client.EntitySet("VendorPaymentFineCodes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPaymentFineCode")]
    public partial class VendorPaymentFineCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorPaymentFineCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="fineCode">Initial value of FineCode.</param>
        /// <param name="days">Initial value of Days.</param>
        /// <param name="finePercentage">Initial value of FinePercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorPaymentFineCode CreateVendorPaymentFineCode(string dataAreaId, string fineCode, int days, decimal finePercentage)
        {
            VendorPaymentFineCode vendorPaymentFineCode = new VendorPaymentFineCode();
            vendorPaymentFineCode.DataAreaId = dataAreaId;
            vendorPaymentFineCode.FineCode = fineCode;
            vendorPaymentFineCode.Days = days;
            vendorPaymentFineCode.FinePercentage = finePercentage;
            return vendorPaymentFineCode;
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
        /// There are no comments for Property FineCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FineCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FineCode is required.")]
        public virtual string FineCode
        {
            get
            {
                return this._FineCode;
            }
            set
            {
                this.OnFineCodeChanging(value);
                this._FineCode = value;
                this.OnFineCodeChanged();
                this.OnPropertyChanged("FineCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FineCode;
        partial void OnFineCodeChanging(string value);
        partial void OnFineCodeChanged();
        /// <summary>
        /// There are no comments for Property Days in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Days")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Days is required.")]
        public virtual int Days
        {
            get
            {
                return this._Days;
            }
            set
            {
                this.OnDaysChanging(value);
                this._Days = value;
                this.OnDaysChanged();
                this.OnPropertyChanged("Days");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Days;
        partial void OnDaysChanging(int value);
        partial void OnDaysChanged();
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
        /// There are no comments for Property FinePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FinePercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FinePercentage is required.")]
        public virtual decimal FinePercentage
        {
            get
            {
                return this._FinePercentage;
            }
            set
            {
                this.OnFinePercentageChanging(value);
                this._FinePercentage = value;
                this.OnFinePercentageChanged();
                this.OnPropertyChanged("FinePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FinePercentage;
        partial void OnFinePercentageChanging(decimal value);
        partial void OnFinePercentageChanged();
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
