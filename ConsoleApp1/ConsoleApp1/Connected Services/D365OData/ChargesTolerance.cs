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
    /// There are no comments for ChargesToleranceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ChargesToleranceSingle")]
    public partial class ChargesToleranceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ChargesTolerance>
    {
        /// <summary>
        /// Initialize a new ChargesToleranceSingle object.
        /// </summary>
        public ChargesToleranceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ChargesToleranceSingle object.
        /// </summary>
        public ChargesToleranceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ChargesToleranceSingle object.
        /// </summary>
        public ChargesToleranceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ChargesTolerance> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ChargesTolerance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// ChargesCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ChargesCode")]
    [global::Microsoft.OData.Client.EntitySet("ChargesTolerances")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ChargesTolerance")]
    public partial class ChargesTolerance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ChargesTolerance object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="chargesCode">Initial value of ChargesCode.</param>
        /// <param name="chargesTolerancePercentage">Initial value of ChargesTolerancePercentage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ChargesTolerance CreateChargesTolerance(string dataAreaId, string chargesCode, decimal chargesTolerancePercentage)
        {
            ChargesTolerance chargesTolerance = new ChargesTolerance();
            chargesTolerance.DataAreaId = dataAreaId;
            chargesTolerance.ChargesCode = chargesCode;
            chargesTolerance.ChargesTolerancePercentage = chargesTolerancePercentage;
            return chargesTolerance;
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
        /// There are no comments for Property ChargesCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargesCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargesCode is required.")]
        public virtual string ChargesCode
        {
            get
            {
                return this._ChargesCode;
            }
            set
            {
                this.OnChargesCodeChanging(value);
                this._ChargesCode = value;
                this.OnChargesCodeChanged();
                this.OnPropertyChanged("ChargesCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargesCode;
        partial void OnChargesCodeChanging(string value);
        partial void OnChargesCodeChanged();
        /// <summary>
        /// There are no comments for Property IntrastatStatisticalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntrastatStatisticalValue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IntrastatStatisticalValue
        {
            get
            {
                return this._IntrastatStatisticalValue;
            }
            set
            {
                this.OnIntrastatStatisticalValueChanging(value);
                this._IntrastatStatisticalValue = value;
                this.OnIntrastatStatisticalValueChanged();
                this.OnPropertyChanged("IntrastatStatisticalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IntrastatStatisticalValue;
        partial void OnIntrastatStatisticalValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIntrastatStatisticalValueChanged();
        /// <summary>
        /// There are no comments for Property IsLetterofCreditEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsLetterofCreditEnabled")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsLetterofCreditEnabled
        {
            get
            {
                return this._IsLetterofCreditEnabled;
            }
            set
            {
                this.OnIsLetterofCreditEnabledChanging(value);
                this._IsLetterofCreditEnabled = value;
                this.OnIsLetterofCreditEnabledChanged();
                this.OnPropertyChanged("IsLetterofCreditEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsLetterofCreditEnabled;
        partial void OnIsLetterofCreditEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsLetterofCreditEnabledChanged();
        /// <summary>
        /// There are no comments for Property IntrastatInvoiceValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IntrastatInvoiceValue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IntrastatInvoiceValue
        {
            get
            {
                return this._IntrastatInvoiceValue;
            }
            set
            {
                this.OnIntrastatInvoiceValueChanging(value);
                this._IntrastatInvoiceValue = value;
                this.OnIntrastatInvoiceValueChanged();
                this.OnPropertyChanged("IntrastatInvoiceValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IntrastatInvoiceValue;
        partial void OnIntrastatInvoiceValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIntrastatInvoiceValueChanged();
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
        /// There are no comments for Property ChargesTolerancePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargesTolerancePercentage")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargesTolerancePercentage is required.")]
        public virtual decimal ChargesTolerancePercentage
        {
            get
            {
                return this._ChargesTolerancePercentage;
            }
            set
            {
                this.OnChargesTolerancePercentageChanging(value);
                this._ChargesTolerancePercentage = value;
                this.OnChargesTolerancePercentageChanged();
                this.OnPropertyChanged("ChargesTolerancePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargesTolerancePercentage;
        partial void OnChargesTolerancePercentageChanging(decimal value);
        partial void OnChargesTolerancePercentageChanged();
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
