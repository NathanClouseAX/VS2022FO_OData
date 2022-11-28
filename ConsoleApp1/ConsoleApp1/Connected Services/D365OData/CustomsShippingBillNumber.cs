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
    /// There are no comments for CustomsShippingBillNumberSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomsShippingBillNumberSingle")]
    public partial class CustomsShippingBillNumberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomsShippingBillNumber>
    {
        /// <summary>
        /// Initialize a new CustomsShippingBillNumberSingle object.
        /// </summary>
        public CustomsShippingBillNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomsShippingBillNumberSingle object.
        /// </summary>
        public CustomsShippingBillNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomsShippingBillNumberSingle object.
        /// </summary>
        public CustomsShippingBillNumberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomsShippingBillNumber> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CustomsShippingBillNumber in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ShippingBill
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ShippingBill")]
    [global::Microsoft.OData.Client.EntitySet("CustomsShippingBillNumbers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomsShippingBillNumber")]
    public partial class CustomsShippingBillNumber : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomsShippingBillNumber object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="shippingBill">Initial value of ShippingBill.</param>
        /// <param name="date">Initial value of Date.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomsShippingBillNumber CreateCustomsShippingBillNumber(string dataAreaId, string shippingBill, global::System.DateTimeOffset date)
        {
            CustomsShippingBillNumber customsShippingBillNumber = new CustomsShippingBillNumber();
            customsShippingBillNumber.DataAreaId = dataAreaId;
            customsShippingBillNumber.ShippingBill = shippingBill;
            customsShippingBillNumber.Date = date;
            return customsShippingBillNumber;
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
        /// There are no comments for Property ShippingBill in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingBill")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ShippingBill is required.")]
        public virtual string ShippingBill
        {
            get
            {
                return this._ShippingBill;
            }
            set
            {
                this.OnShippingBillChanging(value);
                this._ShippingBill = value;
                this.OnShippingBillChanged();
                this.OnPropertyChanged("ShippingBill");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingBill;
        partial void OnShippingBillChanging(string value);
        partial void OnShippingBillChanged();
        /// <summary>
        /// There are no comments for Property Closed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Closed")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Closed
        {
            get
            {
                return this._Closed;
            }
            set
            {
                this.OnClosedChanging(value);
                this._Closed = value;
                this.OnClosedChanged();
                this.OnPropertyChanged("Closed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Closed;
        partial void OnClosedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnClosedChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Date is required.")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
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