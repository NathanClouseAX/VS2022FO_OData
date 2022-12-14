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
    /// There are no comments for BenefitsLifeEventTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsLifeEventTypeSingle")]
    public partial class BenefitsLifeEventTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsLifeEventType>
    {
        /// <summary>
        /// Initialize a new BenefitsLifeEventTypeSingle object.
        /// </summary>
        public BenefitsLifeEventTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitsLifeEventTypeSingle object.
        /// </summary>
        public BenefitsLifeEventTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitsLifeEventTypeSingle object.
        /// </summary>
        public BenefitsLifeEventTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitsLifeEventType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitsEmployeeFutureLifeEventTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEmployeeFutureLifeEventTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction> BenefitsEmployeeFutureLifeEventTransaction
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsEmployeeFutureLifeEventTransaction == null))
                {
                    this._BenefitsEmployeeFutureLifeEventTransaction = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction>(GetPath("BenefitsEmployeeFutureLifeEventTransaction"));
                }
                return this._BenefitsEmployeeFutureLifeEventTransaction;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction> _BenefitsEmployeeFutureLifeEventTransaction;
        /// <summary>
        /// There are no comments for BenefitsPeriodEmployeeLifeEventTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriodEmployeeLifeEventTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> BenefitsPeriodEmployeeLifeEventTransaction
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsPeriodEmployeeLifeEventTransaction == null))
                {
                    this._BenefitsPeriodEmployeeLifeEventTransaction = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction>(GetPath("BenefitsPeriodEmployeeLifeEventTransaction"));
                }
                return this._BenefitsPeriodEmployeeLifeEventTransaction;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> _BenefitsPeriodEmployeeLifeEventTransaction;
        /// <summary>
        /// There are no comments for BenefitsLifeEventOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsLifeEventOption")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption> BenefitsLifeEventOption
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitsLifeEventOption == null))
                {
                    this._BenefitsLifeEventOption = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption>(GetPath("BenefitsLifeEventOption"));
                }
                return this._BenefitsLifeEventOption;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption> _BenefitsLifeEventOption;
    }
    /// <summary>
    /// There are no comments for BenefitsLifeEventType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LifeEventTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LifeEventTypeId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitsLifeEventTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsLifeEventType")]
    public partial class BenefitsLifeEventType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitsLifeEventType object.
        /// </summary>
        /// <param name="lifeEventTypeId">Initial value of LifeEventTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitsLifeEventType CreateBenefitsLifeEventType(string lifeEventTypeId)
        {
            BenefitsLifeEventType benefitsLifeEventType = new BenefitsLifeEventType();
            benefitsLifeEventType.LifeEventTypeId = lifeEventTypeId;
            return benefitsLifeEventType;
        }
        /// <summary>
        /// There are no comments for Property LifeEventTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LifeEventTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LifeEventTypeId is required.")]
        public virtual string LifeEventTypeId
        {
            get
            {
                return this._LifeEventTypeId;
            }
            set
            {
                this.OnLifeEventTypeIdChanging(value);
                this._LifeEventTypeId = value;
                this.OnLifeEventTypeIdChanged();
                this.OnPropertyChanged("LifeEventTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifeEventTypeId;
        partial void OnLifeEventTypeIdChanging(string value);
        partial void OnLifeEventTypeIdChanged();
        /// <summary>
        /// There are no comments for Property LifeEventType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LifeEventType")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitLifeEventTypes> LifeEventType
        {
            get
            {
                return this._LifeEventType;
            }
            set
            {
                this.OnLifeEventTypeChanging(value);
                this._LifeEventType = value;
                this.OnLifeEventTypeChanged();
                this.OnPropertyChanged("LifeEventType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitLifeEventTypes> _LifeEventType;
        partial void OnLifeEventTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BenefitLifeEventTypes> value);
        partial void OnLifeEventTypeChanged();
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
        /// There are no comments for Property BenefitsEmployeeFutureLifeEventTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsEmployeeFutureLifeEventTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction> BenefitsEmployeeFutureLifeEventTransaction
        {
            get
            {
                return this._BenefitsEmployeeFutureLifeEventTransaction;
            }
            set
            {
                this.OnBenefitsEmployeeFutureLifeEventTransactionChanging(value);
                this._BenefitsEmployeeFutureLifeEventTransaction = value;
                this.OnBenefitsEmployeeFutureLifeEventTransactionChanged();
                this.OnPropertyChanged("BenefitsEmployeeFutureLifeEventTransaction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction> _BenefitsEmployeeFutureLifeEventTransaction = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsEmployeeFutureLifeEventTransactionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsEmployeeFutureLifeEventTransaction> value);
        partial void OnBenefitsEmployeeFutureLifeEventTransactionChanged();
        /// <summary>
        /// There are no comments for Property BenefitsPeriodEmployeeLifeEventTransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsPeriodEmployeeLifeEventTransaction")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> BenefitsPeriodEmployeeLifeEventTransaction
        {
            get
            {
                return this._BenefitsPeriodEmployeeLifeEventTransaction;
            }
            set
            {
                this.OnBenefitsPeriodEmployeeLifeEventTransactionChanging(value);
                this._BenefitsPeriodEmployeeLifeEventTransaction = value;
                this.OnBenefitsPeriodEmployeeLifeEventTransactionChanged();
                this.OnPropertyChanged("BenefitsPeriodEmployeeLifeEventTransaction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> _BenefitsPeriodEmployeeLifeEventTransaction = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsPeriodEmployeeLifeEventTransactionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsPeriodEmployeeLifeEventTransaction> value);
        partial void OnBenefitsPeriodEmployeeLifeEventTransactionChanged();
        /// <summary>
        /// There are no comments for Property BenefitsLifeEventOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitsLifeEventOption")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption> BenefitsLifeEventOption
        {
            get
            {
                return this._BenefitsLifeEventOption;
            }
            set
            {
                this.OnBenefitsLifeEventOptionChanging(value);
                this._BenefitsLifeEventOption = value;
                this.OnBenefitsLifeEventOptionChanged();
                this.OnPropertyChanged("BenefitsLifeEventOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption> _BenefitsLifeEventOption = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitsLifeEventOptionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitsLifeEventOption> value);
        partial void OnBenefitsLifeEventOptionChanged();
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
