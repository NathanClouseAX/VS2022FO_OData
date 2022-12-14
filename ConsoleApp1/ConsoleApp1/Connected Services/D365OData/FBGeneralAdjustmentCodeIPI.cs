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
    /// There are no comments for FBGeneralAdjustmentCodeIPISingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FBGeneralAdjustmentCodeIPISingle")]
    public partial class FBGeneralAdjustmentCodeIPISingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FBGeneralAdjustmentCodeIPI>
    {
        /// <summary>
        /// Initialize a new FBGeneralAdjustmentCodeIPISingle object.
        /// </summary>
        public FBGeneralAdjustmentCodeIPISingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FBGeneralAdjustmentCodeIPISingle object.
        /// </summary>
        public FBGeneralAdjustmentCodeIPISingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FBGeneralAdjustmentCodeIPISingle object.
        /// </summary>
        public FBGeneralAdjustmentCodeIPISingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FBGeneralAdjustmentCodeIPI> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for FBGeneralAdjustmentCodeIPI in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AdjustmentCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AdjustmentCode")]
    [global::Microsoft.OData.Client.EntitySet("FBGeneralAdjustmentCodesIPI")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FBGeneralAdjustmentCodeIPI")]
    public partial class FBGeneralAdjustmentCodeIPI : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FBGeneralAdjustmentCodeIPI object.
        /// </summary>
        /// <param name="adjustmentCode">Initial value of AdjustmentCode.</param>
        /// <param name="validToDate">Initial value of ValidToDate.</param>
        /// <param name="validFromDate">Initial value of ValidFromDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FBGeneralAdjustmentCodeIPI CreateFBGeneralAdjustmentCodeIPI(string adjustmentCode, global::System.DateTimeOffset validToDate, global::System.DateTimeOffset validFromDate)
        {
            FBGeneralAdjustmentCodeIPI fBGeneralAdjustmentCodeIPI = new FBGeneralAdjustmentCodeIPI();
            fBGeneralAdjustmentCodeIPI.AdjustmentCode = adjustmentCode;
            fBGeneralAdjustmentCodeIPI.ValidToDate = validToDate;
            fBGeneralAdjustmentCodeIPI.ValidFromDate = validFromDate;
            return fBGeneralAdjustmentCodeIPI;
        }
        /// <summary>
        /// There are no comments for Property AdjustmentCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdjustmentCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AdjustmentCode is required.")]
        public virtual string AdjustmentCode
        {
            get
            {
                return this._AdjustmentCode;
            }
            set
            {
                this.OnAdjustmentCodeChanging(value);
                this._AdjustmentCode = value;
                this.OnAdjustmentCodeChanged();
                this.OnPropertyChanged("AdjustmentCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdjustmentCode;
        partial void OnAdjustmentCodeChanging(string value);
        partial void OnAdjustmentCodeChanged();
        /// <summary>
        /// There are no comments for Property ReceitaCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceitaCode")]
        public virtual string ReceitaCode
        {
            get
            {
                return this._ReceitaCode;
            }
            set
            {
                this.OnReceitaCodeChanging(value);
                this._ReceitaCode = value;
                this.OnReceitaCodeChanged();
                this.OnPropertyChanged("ReceitaCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceitaCode;
        partial void OnReceitaCodeChanging(string value);
        partial void OnReceitaCodeChanged();
        /// <summary>
        /// There are no comments for Property OtherDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OtherDebit")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> OtherDebit
        {
            get
            {
                return this._OtherDebit;
            }
            set
            {
                this.OnOtherDebitChanging(value);
                this._OtherDebit = value;
                this.OnOtherDebitChanged();
                this.OnPropertyChanged("OtherDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _OtherDebit;
        partial void OnOtherDebitChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnOtherDebitChanged();
        /// <summary>
        /// There are no comments for Property IsReversal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsReversal")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsReversal
        {
            get
            {
                return this._IsReversal;
            }
            set
            {
                this.OnIsReversalChanging(value);
                this._IsReversal = value;
                this.OnIsReversalChanged();
                this.OnPropertyChanged("IsReversal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsReversal;
        partial void OnIsReversalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsReversalChanged();
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
        /// There are no comments for Property ValidToDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidToDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidToDate is required.")]
        public virtual global::System.DateTimeOffset ValidToDate
        {
            get
            {
                return this._ValidToDate;
            }
            set
            {
                this.OnValidToDateChanging(value);
                this._ValidToDate = value;
                this.OnValidToDateChanged();
                this.OnPropertyChanged("ValidToDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidToDate;
        partial void OnValidToDateChanging(global::System.DateTimeOffset value);
        partial void OnValidToDateChanged();
        /// <summary>
        /// There are no comments for Property ValidFromDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFromDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFromDate is required.")]
        public virtual global::System.DateTimeOffset ValidFromDate
        {
            get
            {
                return this._ValidFromDate;
            }
            set
            {
                this.OnValidFromDateChanging(value);
                this._ValidFromDate = value;
                this.OnValidFromDateChanged();
                this.OnPropertyChanged("ValidFromDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFromDate;
        partial void OnValidFromDateChanging(global::System.DateTimeOffset value);
        partial void OnValidFromDateChanged();
        /// <summary>
        /// There are no comments for Property IsTaxRefund in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsTaxRefund")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTaxRefund
        {
            get
            {
                return this._IsTaxRefund;
            }
            set
            {
                this.OnIsTaxRefundChanging(value);
                this._IsTaxRefund = value;
                this.OnIsTaxRefundChanged();
                this.OnPropertyChanged("IsTaxRefund");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTaxRefund;
        partial void OnIsTaxRefundChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTaxRefundChanged();
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
