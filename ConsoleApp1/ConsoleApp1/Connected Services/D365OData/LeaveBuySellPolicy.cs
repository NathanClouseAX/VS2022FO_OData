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
    /// There are no comments for LeaveBuySellPolicySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellPolicySingle")]
    public partial class LeaveBuySellPolicySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaveBuySellPolicy>
    {
        /// <summary>
        /// Initialize a new LeaveBuySellPolicySingle object.
        /// </summary>
        public LeaveBuySellPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaveBuySellPolicySingle object.
        /// </summary>
        public LeaveBuySellPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaveBuySellPolicySingle object.
        /// </summary>
        public LeaveBuySellPolicySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaveBuySellPolicy> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LeaveBuySellPolicySellTier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellPolicySellTier")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicySellTierSingle LeaveBuySellPolicySellTier
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveBuySellPolicySellTier == null))
                {
                    this._LeaveBuySellPolicySellTier = new global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicySellTierSingle(this.Context, GetPath("LeaveBuySellPolicySellTier"));
                }
                return this._LeaveBuySellPolicySellTier;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicySellTierSingle _LeaveBuySellPolicySellTier;
        /// <summary>
        /// There are no comments for LeaveBuySellRequest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellRequest")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest> LeaveBuySellRequest
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveBuySellRequest == null))
                {
                    this._LeaveBuySellRequest = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest>(GetPath("LeaveBuySellRequest"));
                }
                return this._LeaveBuySellRequest;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest> _LeaveBuySellRequest;
        /// <summary>
        /// There are no comments for LeaveBuySellPolicyBuyTier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellPolicyBuyTier")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyBuyTierSingle LeaveBuySellPolicyBuyTier
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LeaveBuySellPolicyBuyTier == null))
                {
                    this._LeaveBuySellPolicyBuyTier = new global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyBuyTierSingle(this.Context, GetPath("LeaveBuySellPolicyBuyTier"));
                }
                return this._LeaveBuySellPolicyBuyTier;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyBuyTierSingle _LeaveBuySellPolicyBuyTier;
    }
    /// <summary>
    /// There are no comments for LeaveBuySellPolicy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Policy
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Policy")]
    [global::Microsoft.OData.Client.EntitySet("LeaveBuySellPolicies")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellPolicy")]
    public partial class LeaveBuySellPolicy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaveBuySellPolicy object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="policy">Initial value of Policy.</param>
        /// <param name="maximumAmount_Sell">Initial value of MaximumAmount_Sell.</param>
        /// <param name="startDate">Initial value of StartDate.</param>
        /// <param name="endDate">Initial value of EndDate.</param>
        /// <param name="maximumAmount_Buy">Initial value of MaximumAmount_Buy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaveBuySellPolicy CreateLeaveBuySellPolicy(string dataAreaId, 
                    string policy, 
                    decimal maximumAmount_Sell, 
                    global::System.DateTimeOffset startDate, 
                    global::System.DateTimeOffset endDate, 
                    decimal maximumAmount_Buy)
        {
            LeaveBuySellPolicy leaveBuySellPolicy = new LeaveBuySellPolicy();
            leaveBuySellPolicy.DataAreaId = dataAreaId;
            leaveBuySellPolicy.Policy = policy;
            leaveBuySellPolicy.MaximumAmount_Sell = maximumAmount_Sell;
            leaveBuySellPolicy.StartDate = startDate;
            leaveBuySellPolicy.EndDate = endDate;
            leaveBuySellPolicy.MaximumAmount_Buy = maximumAmount_Buy;
            return leaveBuySellPolicy;
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
        /// There are no comments for Property Policy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Policy")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Policy is required.")]
        public virtual string Policy
        {
            get
            {
                return this._Policy;
            }
            set
            {
                this.OnPolicyChanging(value);
                this._Policy = value;
                this.OnPolicyChanged();
                this.OnPropertyChanged("Policy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Policy;
        partial void OnPolicyChanging(string value);
        partial void OnPolicyChanged();
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
        /// There are no comments for Property MaximumAmount_Sell in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumAmount_Sell")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumAmount_Sell is required.")]
        public virtual decimal MaximumAmount_Sell
        {
            get
            {
                return this._MaximumAmount_Sell;
            }
            set
            {
                this.OnMaximumAmount_SellChanging(value);
                this._MaximumAmount_Sell = value;
                this.OnMaximumAmount_SellChanged();
                this.OnPropertyChanged("MaximumAmount_Sell");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumAmount_Sell;
        partial void OnMaximumAmount_SellChanging(decimal value);
        partial void OnMaximumAmount_SellChanged();
        /// <summary>
        /// There are no comments for Property Category in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Category")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyTypeCategory> Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this.OnCategoryChanging(value);
                this._Category = value;
                this.OnCategoryChanged();
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyTypeCategory> _Category;
        partial void OnCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyTypeCategory> value);
        partial void OnCategoryChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StartDate is required.")]
        public virtual global::System.DateTimeOffset StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDate;
        partial void OnStartDateChanging(global::System.DateTimeOffset value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property UseFullTimeEquivalency_Sell in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseFullTimeEquivalency_Sell")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseFullTimeEquivalency_Sell
        {
            get
            {
                return this._UseFullTimeEquivalency_Sell;
            }
            set
            {
                this.OnUseFullTimeEquivalency_SellChanging(value);
                this._UseFullTimeEquivalency_Sell = value;
                this.OnUseFullTimeEquivalency_SellChanged();
                this.OnPropertyChanged("UseFullTimeEquivalency_Sell");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseFullTimeEquivalency_Sell;
        partial void OnUseFullTimeEquivalency_SellChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseFullTimeEquivalency_SellChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDate is required.")]
        public virtual global::System.DateTimeOffset EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDate;
        partial void OnEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property MaximumAmount_Buy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MaximumAmount_Buy")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumAmount_Buy is required.")]
        public virtual decimal MaximumAmount_Buy
        {
            get
            {
                return this._MaximumAmount_Buy;
            }
            set
            {
                this.OnMaximumAmount_BuyChanging(value);
                this._MaximumAmount_Buy = value;
                this.OnMaximumAmount_BuyChanged();
                this.OnPropertyChanged("MaximumAmount_Buy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumAmount_Buy;
        partial void OnMaximumAmount_BuyChanging(decimal value);
        partial void OnMaximumAmount_BuyChanged();
        /// <summary>
        /// There are no comments for Property UseFullTimeEquivalency_Buy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseFullTimeEquivalency_Buy")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> UseFullTimeEquivalency_Buy
        {
            get
            {
                return this._UseFullTimeEquivalency_Buy;
            }
            set
            {
                this.OnUseFullTimeEquivalency_BuyChanging(value);
                this._UseFullTimeEquivalency_Buy = value;
                this.OnUseFullTimeEquivalency_BuyChanged();
                this.OnPropertyChanged("UseFullTimeEquivalency_Buy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _UseFullTimeEquivalency_Buy;
        partial void OnUseFullTimeEquivalency_BuyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnUseFullTimeEquivalency_BuyChanged();
        /// <summary>
        /// There are no comments for Property LeaveBuySellPolicySellTier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellPolicySellTier")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicySellTier LeaveBuySellPolicySellTier
        {
            get
            {
                return this._LeaveBuySellPolicySellTier;
            }
            set
            {
                this.OnLeaveBuySellPolicySellTierChanging(value);
                this._LeaveBuySellPolicySellTier = value;
                this.OnLeaveBuySellPolicySellTierChanged();
                this.OnPropertyChanged("LeaveBuySellPolicySellTier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicySellTier _LeaveBuySellPolicySellTier;
        partial void OnLeaveBuySellPolicySellTierChanging(global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicySellTier value);
        partial void OnLeaveBuySellPolicySellTierChanged();
        /// <summary>
        /// There are no comments for Property LeaveBuySellRequest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellRequest")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest> LeaveBuySellRequest
        {
            get
            {
                return this._LeaveBuySellRequest;
            }
            set
            {
                this.OnLeaveBuySellRequestChanging(value);
                this._LeaveBuySellRequest = value;
                this.OnLeaveBuySellRequestChanged();
                this.OnPropertyChanged("LeaveBuySellRequest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest> _LeaveBuySellRequest = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLeaveBuySellRequestChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LeaveBuySellRequest> value);
        partial void OnLeaveBuySellRequestChanged();
        /// <summary>
        /// There are no comments for Property LeaveBuySellPolicyBuyTier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LeaveBuySellPolicyBuyTier")]
        public virtual global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyBuyTier LeaveBuySellPolicyBuyTier
        {
            get
            {
                return this._LeaveBuySellPolicyBuyTier;
            }
            set
            {
                this.OnLeaveBuySellPolicyBuyTierChanging(value);
                this._LeaveBuySellPolicyBuyTier = value;
                this.OnLeaveBuySellPolicyBuyTierChanged();
                this.OnPropertyChanged("LeaveBuySellPolicyBuyTier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyBuyTier _LeaveBuySellPolicyBuyTier;
        partial void OnLeaveBuySellPolicyBuyTierChanging(global::Microsoft.Dynamics.DataEntities.LeaveBuySellPolicyBuyTier value);
        partial void OnLeaveBuySellPolicyBuyTierChanged();
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
