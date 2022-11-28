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
    /// There are no comments for TaxPeriodHeadSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxPeriodHeadSingle")]
    public partial class TaxPeriodHeadSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxPeriodHead>
    {
        /// <summary>
        /// Initialize a new TaxPeriodHeadSingle object.
        /// </summary>
        public TaxPeriodHeadSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxPeriodHeadSingle object.
        /// </summary>
        public TaxPeriodHeadSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxPeriodHeadSingle object.
        /// </summary>
        public TaxPeriodHeadSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxPeriodHead> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TaxPeriodHead in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// TaxPeriodId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxPeriodId")]
    [global::Microsoft.OData.Client.EntitySet("TaxPeriodHeads")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxPeriodHead")]
    public partial class TaxPeriodHead : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxPeriodHead object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="taxPeriodId">Initial value of TaxPeriodId.</param>
        /// <param name="duration">Initial value of Duration.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxPeriodHead CreateTaxPeriodHead(string dataAreaId, string taxPeriodId, int duration)
        {
            TaxPeriodHead taxPeriodHead = new TaxPeriodHead();
            taxPeriodHead.DataAreaId = dataAreaId;
            taxPeriodHead.TaxPeriodId = taxPeriodId;
            taxPeriodHead.Duration = duration;
            return taxPeriodHead;
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
        /// There are no comments for Property TaxPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxPeriodId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TaxPeriodId is required.")]
        public virtual string TaxPeriodId
        {
            get
            {
                return this._TaxPeriodId;
            }
            set
            {
                this.OnTaxPeriodIdChanging(value);
                this._TaxPeriodId = value;
                this.OnTaxPeriodIdChanged();
                this.OnPropertyChanged("TaxPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxPeriodId;
        partial void OnTaxPeriodIdChanging(string value);
        partial void OnTaxPeriodIdChanged();
        /// <summary>
        /// There are no comments for Property Duration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Duration")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Duration is required.")]
        public virtual int Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.OnDurationChanging(value);
                this._Duration = value;
                this.OnDurationChanged();
                this.OnPropertyChanged("Duration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Duration;
        partial void OnDurationChanging(int value);
        partial void OnDurationChanged();
        /// <summary>
        /// There are no comments for Property TaxAuthority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAuthority")]
        public virtual string TaxAuthority
        {
            get
            {
                return this._TaxAuthority;
            }
            set
            {
                this.OnTaxAuthorityChanging(value);
                this._TaxAuthority = value;
                this.OnTaxAuthorityChanged();
                this.OnPropertyChanged("TaxAuthority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxAuthority;
        partial void OnTaxAuthorityChanging(string value);
        partial void OnTaxAuthorityChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DurationUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DurationUnit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> DurationUnit
        {
            get
            {
                return this._DurationUnit;
            }
            set
            {
                this.OnDurationUnitChanging(value);
                this._DurationUnit = value;
                this.OnDurationUnitChanged();
                this.OnPropertyChanged("DurationUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> _DurationUnit;
        partial void OnDurationUnitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PeriodUnit> value);
        partial void OnDurationUnitChanged();
        /// <summary>
        /// There are no comments for Property PaymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTerms")]
        public virtual string PaymentTerms
        {
            get
            {
                return this._PaymentTerms;
            }
            set
            {
                this.OnPaymentTermsChanging(value);
                this._PaymentTerms = value;
                this.OnPaymentTermsChanged();
                this.OnPropertyChanged("PaymentTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentTerms;
        partial void OnPaymentTermsChanging(string value);
        partial void OnPaymentTermsChanged();
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
