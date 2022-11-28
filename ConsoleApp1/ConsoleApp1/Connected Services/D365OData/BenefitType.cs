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
    /// There are no comments for BenefitTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitTypeSingle")]
    public partial class BenefitTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitType>
    {
        /// <summary>
        /// Initialize a new BenefitTypeSingle object.
        /// </summary>
        public BenefitTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BenefitTypeSingle object.
        /// </summary>
        public BenefitTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BenefitTypeSingle object.
        /// </summary>
        public BenefitTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BenefitType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BenefitPlans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitPlans")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitPlan> BenefitPlans
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitPlans == null))
                {
                    this._BenefitPlans = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitPlan>(GetPath("BenefitPlans"));
                }
                return this._BenefitPlans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitPlan> _BenefitPlans;
    }
    /// <summary>
    /// There are no comments for BenefitType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BenefitTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitTypeId")]
    [global::Microsoft.OData.Client.EntitySet("BenefitTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitType")]
    public partial class BenefitType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BenefitType object.
        /// </summary>
        /// <param name="benefitTypeId">Initial value of BenefitTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BenefitType CreateBenefitType(string benefitTypeId)
        {
            BenefitType benefitType = new BenefitType();
            benefitType.BenefitTypeId = benefitTypeId;
            return benefitType;
        }
        /// <summary>
        /// There are no comments for Property BenefitTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BenefitTypeId is required.")]
        public virtual string BenefitTypeId
        {
            get
            {
                return this._BenefitTypeId;
            }
            set
            {
                this.OnBenefitTypeIdChanging(value);
                this._BenefitTypeId = value;
                this.OnBenefitTypeIdChanged();
                this.OnPropertyChanged("BenefitTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitTypeId;
        partial void OnBenefitTypeIdChanging(string value);
        partial void OnBenefitTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ConcurrentEnrollment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConcurrentEnrollment")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmBenefitConcurrentEnrollment> ConcurrentEnrollment
        {
            get
            {
                return this._ConcurrentEnrollment;
            }
            set
            {
                this.OnConcurrentEnrollmentChanging(value);
                this._ConcurrentEnrollment = value;
                this.OnConcurrentEnrollmentChanged();
                this.OnPropertyChanged("ConcurrentEnrollment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmBenefitConcurrentEnrollment> _ConcurrentEnrollment;
        partial void OnConcurrentEnrollmentChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmBenefitConcurrentEnrollment> value);
        partial void OnConcurrentEnrollmentChanged();
        /// <summary>
        /// There are no comments for Property PayrollCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayrollCategory")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCategory> PayrollCategory
        {
            get
            {
                return this._PayrollCategory;
            }
            set
            {
                this.OnPayrollCategoryChanging(value);
                this._PayrollCategory = value;
                this.OnPayrollCategoryChanged();
                this.OnPropertyChanged("PayrollCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCategory> _PayrollCategory;
        partial void OnPayrollCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollCategory> value);
        partial void OnPayrollCategoryChanged();
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
        /// There are no comments for Property BenefitPlans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BenefitPlans")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitPlan> BenefitPlans
        {
            get
            {
                return this._BenefitPlans;
            }
            set
            {
                this.OnBenefitPlansChanging(value);
                this._BenefitPlans = value;
                this.OnBenefitPlansChanged();
                this.OnPropertyChanged("BenefitPlans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitPlan> _BenefitPlans = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitPlan>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitPlansChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitPlan> value);
        partial void OnBenefitPlansChanged();
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