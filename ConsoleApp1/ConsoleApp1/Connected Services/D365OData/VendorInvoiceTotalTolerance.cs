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
    /// There are no comments for VendorInvoiceTotalToleranceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorInvoiceTotalToleranceSingle")]
    public partial class VendorInvoiceTotalToleranceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorInvoiceTotalTolerance>
    {
        /// <summary>
        /// Initialize a new VendorInvoiceTotalToleranceSingle object.
        /// </summary>
        public VendorInvoiceTotalToleranceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorInvoiceTotalToleranceSingle object.
        /// </summary>
        public VendorInvoiceTotalToleranceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorInvoiceTotalToleranceSingle object.
        /// </summary>
        public VendorInvoiceTotalToleranceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorInvoiceTotalTolerance> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VendorInvoiceTotalTolerance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// VendorAccount
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VendorAccount")]
    [global::Microsoft.OData.Client.EntitySet("VendorInvoiceTotalTolerances")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("VendorInvoiceTotalTolerance")]
    public partial class VendorInvoiceTotalTolerance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorInvoiceTotalTolerance object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="vendorAccount">Initial value of VendorAccount.</param>
        /// <param name="invoiceTotalsPercentage">Initial value of InvoiceTotalsPercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorInvoiceTotalTolerance CreateVendorInvoiceTotalTolerance(string dataAreaId, string vendorAccount, decimal invoiceTotalsPercentage)
        {
            VendorInvoiceTotalTolerance vendorInvoiceTotalTolerance = new VendorInvoiceTotalTolerance();
            vendorInvoiceTotalTolerance.DataAreaId = dataAreaId;
            vendorInvoiceTotalTolerance.VendorAccount = vendorAccount;
            vendorInvoiceTotalTolerance.InvoiceTotalsPercentage = invoiceTotalsPercentage;
            return vendorInvoiceTotalTolerance;
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
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VendorAccount is required.")]
        public virtual string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property VendorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorName")]
        public virtual string VendorName
        {
            get
            {
                return this._VendorName;
            }
            set
            {
                this.OnVendorNameChanging(value);
                this._VendorName = value;
                this.OnVendorNameChanged();
                this.OnPropertyChanged("VendorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorName;
        partial void OnVendorNameChanging(string value);
        partial void OnVendorNameChanged();
        /// <summary>
        /// There are no comments for Property InvoiceTotalsPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceTotalsPercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InvoiceTotalsPercentage is required.")]
        public virtual decimal InvoiceTotalsPercentage
        {
            get
            {
                return this._InvoiceTotalsPercentage;
            }
            set
            {
                this.OnInvoiceTotalsPercentageChanging(value);
                this._InvoiceTotalsPercentage = value;
                this.OnInvoiceTotalsPercentageChanged();
                this.OnPropertyChanged("InvoiceTotalsPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoiceTotalsPercentage;
        partial void OnInvoiceTotalsPercentageChanging(decimal value);
        partial void OnInvoiceTotalsPercentageChanged();
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
