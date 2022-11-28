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
    /// There are no comments for SADDocumentInvoicePurchaseOrderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentInvoicePurchaseOrderSingle")]
    public partial class SADDocumentInvoicePurchaseOrderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentInvoicePurchaseOrder>
    {
        /// <summary>
        /// Initialize a new SADDocumentInvoicePurchaseOrderSingle object.
        /// </summary>
        public SADDocumentInvoicePurchaseOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADDocumentInvoicePurchaseOrderSingle object.
        /// </summary>
        public SADDocumentInvoicePurchaseOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADDocumentInvoicePurchaseOrderSingle object.
        /// </summary>
        public SADDocumentInvoicePurchaseOrderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentInvoicePurchaseOrder> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for SADDocumentInvoicePurchaseOrder in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DocumentCode
    /// Position
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DocumentCode", "Position")]
    [global::Microsoft.OData.Client.EntitySet("SADDocumentInvoicePurchaseOrders")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SADDocumentInvoicePurchaseOrder")]
    public partial class SADDocumentInvoicePurchaseOrder : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADDocumentInvoicePurchaseOrder object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="documentCode">Initial value of DocumentCode.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="documentDate">Initial value of DocumentDate.</param>
        /// <param name="insurance">Initial value of Insurance.</param>
        /// <param name="invoiceMiscCharg">Initial value of InvoiceMiscCharg.</param>
        /// <param name="transport">Initial value of Transport.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADDocumentInvoicePurchaseOrder CreateSADDocumentInvoicePurchaseOrder(string dataAreaId, 
                    string documentCode, 
                    int position, 
                    global::System.DateTimeOffset documentDate, 
                    decimal insurance, 
                    decimal invoiceMiscCharg, 
                    decimal transport)
        {
            SADDocumentInvoicePurchaseOrder sADDocumentInvoicePurchaseOrder = new SADDocumentInvoicePurchaseOrder();
            sADDocumentInvoicePurchaseOrder.DataAreaId = dataAreaId;
            sADDocumentInvoicePurchaseOrder.DocumentCode = documentCode;
            sADDocumentInvoicePurchaseOrder.Position = position;
            sADDocumentInvoicePurchaseOrder.DocumentDate = documentDate;
            sADDocumentInvoicePurchaseOrder.Insurance = insurance;
            sADDocumentInvoicePurchaseOrder.InvoiceMiscCharg = invoiceMiscCharg;
            sADDocumentInvoicePurchaseOrder.Transport = transport;
            return sADDocumentInvoicePurchaseOrder;
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
        /// There are no comments for Property DocumentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentCode is required.")]
        public virtual string DocumentCode
        {
            get
            {
                return this._DocumentCode;
            }
            set
            {
                this.OnDocumentCodeChanging(value);
                this._DocumentCode = value;
                this.OnDocumentCodeChanged();
                this.OnPropertyChanged("DocumentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentCode;
        partial void OnDocumentCodeChanging(string value);
        partial void OnDocumentCodeChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Position")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Position is required.")]
        public virtual int Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Position;
        partial void OnPositionChanging(int value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property Purchase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Purchase")]
        public virtual string Purchase
        {
            get
            {
                return this._Purchase;
            }
            set
            {
                this.OnPurchaseChanging(value);
                this._Purchase = value;
                this.OnPurchaseChanged();
                this.OnPropertyChanged("Purchase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Purchase;
        partial void OnPurchaseChanging(string value);
        partial void OnPurchaseChanged();
        /// <summary>
        /// There are no comments for Property DocumentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentDate is required.")]
        public virtual global::System.DateTimeOffset DocumentDate
        {
            get
            {
                return this._DocumentDate;
            }
            set
            {
                this.OnDocumentDateChanging(value);
                this._DocumentDate = value;
                this.OnDocumentDateChanged();
                this.OnPropertyChanged("DocumentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DocumentDate;
        partial void OnDocumentDateChanging(global::System.DateTimeOffset value);
        partial void OnDocumentDateChanged();
        /// <summary>
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccount")]
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
        /// There are no comments for Property Insurance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Insurance")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Insurance is required.")]
        public virtual decimal Insurance
        {
            get
            {
                return this._Insurance;
            }
            set
            {
                this.OnInsuranceChanging(value);
                this._Insurance = value;
                this.OnInsuranceChanged();
                this.OnPropertyChanged("Insurance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Insurance;
        partial void OnInsuranceChanging(decimal value);
        partial void OnInsuranceChanged();
        /// <summary>
        /// There are no comments for Property InvoiceMiscCharg in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceMiscCharg")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InvoiceMiscCharg is required.")]
        public virtual decimal InvoiceMiscCharg
        {
            get
            {
                return this._InvoiceMiscCharg;
            }
            set
            {
                this.OnInvoiceMiscChargChanging(value);
                this._InvoiceMiscCharg = value;
                this.OnInvoiceMiscChargChanged();
                this.OnPropertyChanged("InvoiceMiscCharg");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _InvoiceMiscCharg;
        partial void OnInvoiceMiscChargChanging(decimal value);
        partial void OnInvoiceMiscChargChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionDisplayValue")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Transport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Transport")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Transport is required.")]
        public virtual decimal Transport
        {
            get
            {
                return this._Transport;
            }
            set
            {
                this.OnTransportChanging(value);
                this._Transport = value;
                this.OnTransportChanged();
                this.OnPropertyChanged("Transport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Transport;
        partial void OnTransportChanging(decimal value);
        partial void OnTransportChanged();
        /// <summary>
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Invoice")]
        public virtual string Invoice
        {
            get
            {
                return this._Invoice;
            }
            set
            {
                this.OnInvoiceChanging(value);
                this._Invoice = value;
                this.OnInvoiceChanged();
                this.OnPropertyChanged("Invoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Invoice;
        partial void OnInvoiceChanging(string value);
        partial void OnInvoiceChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
