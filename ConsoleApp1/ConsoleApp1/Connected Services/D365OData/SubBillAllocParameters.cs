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
    /// There are no comments for SubBillAllocParametersSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillAllocParametersSingle")]
    public partial class SubBillAllocParametersSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillAllocParameters>
    {
        /// <summary>
        /// Initialize a new SubBillAllocParametersSingle object.
        /// </summary>
        public SubBillAllocParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SubBillAllocParametersSingle object.
        /// </summary>
        public SubBillAllocParametersSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SubBillAllocParametersSingle object.
        /// </summary>
        public SubBillAllocParametersSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SubBillAllocParameters> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SubBillAllocDeferralRoundingAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillAllocDeferralRoundingAccountCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle SubBillAllocDeferralRoundingAccountCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SubBillAllocDeferralRoundingAccountCombination == null))
                {
                    this._SubBillAllocDeferralRoundingAccountCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("SubBillAllocDeferralRoundingAccountCombination"));
                }
                return this._SubBillAllocDeferralRoundingAccountCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _SubBillAllocDeferralRoundingAccountCombination;
    }
    /// <summary>
    /// There are no comments for SubBillAllocParameters in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId")]
    [global::Microsoft.OData.Client.EntitySet("SubBillAllocParametersCollection")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillAllocParameters")]
    public partial class SubBillAllocParameters : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SubBillAllocParameters object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SubBillAllocParameters CreateSubBillAllocParameters(string dataAreaId)
        {
            SubBillAllocParameters subBillAllocParameters = new SubBillAllocParameters();
            subBillAllocParameters.DataAreaId = dataAreaId;
            return subBillAllocParameters;
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
        /// There are no comments for Property StandaloneSellingPriceOrigin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StandaloneSellingPriceOrigin")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillAllocStandaloneSellingPriceOrigin> StandaloneSellingPriceOrigin
        {
            get
            {
                return this._StandaloneSellingPriceOrigin;
            }
            set
            {
                this.OnStandaloneSellingPriceOriginChanging(value);
                this._StandaloneSellingPriceOrigin = value;
                this.OnStandaloneSellingPriceOriginChanged();
                this.OnPropertyChanged("StandaloneSellingPriceOrigin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillAllocStandaloneSellingPriceOrigin> _StandaloneSellingPriceOrigin;
        partial void OnStandaloneSellingPriceOriginChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SubBillAllocStandaloneSellingPriceOrigin> value);
        partial void OnStandaloneSellingPriceOriginChanged();
        /// <summary>
        /// There are no comments for Property DeferralRoundingAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralRoundingAccountDisplayValue")]
        public virtual string DeferralRoundingAccountDisplayValue
        {
            get
            {
                return this._DeferralRoundingAccountDisplayValue;
            }
            set
            {
                this.OnDeferralRoundingAccountDisplayValueChanging(value);
                this._DeferralRoundingAccountDisplayValue = value;
                this.OnDeferralRoundingAccountDisplayValueChanged();
                this.OnPropertyChanged("DeferralRoundingAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeferralRoundingAccountDisplayValue;
        partial void OnDeferralRoundingAccountDisplayValueChanging(string value);
        partial void OnDeferralRoundingAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property SubBillAllocDeferralRoundingAccountCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubBillAllocDeferralRoundingAccountCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination SubBillAllocDeferralRoundingAccountCombination
        {
            get
            {
                return this._SubBillAllocDeferralRoundingAccountCombination;
            }
            set
            {
                this.OnSubBillAllocDeferralRoundingAccountCombinationChanging(value);
                this._SubBillAllocDeferralRoundingAccountCombination = value;
                this.OnSubBillAllocDeferralRoundingAccountCombinationChanged();
                this.OnPropertyChanged("SubBillAllocDeferralRoundingAccountCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _SubBillAllocDeferralRoundingAccountCombination;
        partial void OnSubBillAllocDeferralRoundingAccountCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnSubBillAllocDeferralRoundingAccountCombinationChanged();
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