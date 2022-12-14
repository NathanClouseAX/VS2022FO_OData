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
    /// There are no comments for CustomerPostingProfileSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPostingProfileSingle")]
    public partial class CustomerPostingProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPostingProfile>
    {
        /// <summary>
        /// Initialize a new CustomerPostingProfileSingle object.
        /// </summary>
        public CustomerPostingProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerPostingProfileSingle object.
        /// </summary>
        public CustomerPostingProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerPostingProfileSingle object.
        /// </summary>
        public CustomerPostingProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPostingProfile> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustCustomerPostingProfileHead in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustCustomerPostingProfileHead")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine> CustCustomerPostingProfileHead
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustCustomerPostingProfileHead == null))
                {
                    this._CustCustomerPostingProfileHead = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine>(GetPath("CustCustomerPostingProfileHead"));
                }
                return this._CustCustomerPostingProfileHead;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine> _CustCustomerPostingProfileHead;
    }
    /// <summary>
    /// There are no comments for CustomerPostingProfile in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// PostingProfile
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PostingProfile")]
    [global::Microsoft.OData.Client.EntitySet("CustomerPostingProfiles")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerPostingProfile")]
    public partial class CustomerPostingProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerPostingProfile object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="postingProfile">Initial value of PostingProfile.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerPostingProfile CreateCustomerPostingProfile(string dataAreaId, string postingProfile)
        {
            CustomerPostingProfile customerPostingProfile = new CustomerPostingProfile();
            customerPostingProfile.DataAreaId = dataAreaId;
            customerPostingProfile.PostingProfile = postingProfile;
            return customerPostingProfile;
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
        /// There are no comments for Property PostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingProfile")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PostingProfile is required.")]
        public virtual string PostingProfile
        {
            get
            {
                return this._PostingProfile;
            }
            set
            {
                this.OnPostingProfileChanging(value);
                this._PostingProfile = value;
                this.OnPostingProfileChanged();
                this.OnPropertyChanged("PostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfile;
        partial void OnPostingProfileChanging(string value);
        partial void OnPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property PostingProfileToCloseSettlement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingProfileToCloseSettlement")]
        public virtual string PostingProfileToCloseSettlement
        {
            get
            {
                return this._PostingProfileToCloseSettlement;
            }
            set
            {
                this.OnPostingProfileToCloseSettlementChanging(value);
                this._PostingProfileToCloseSettlement = value;
                this.OnPostingProfileToCloseSettlementChanged();
                this.OnPropertyChanged("PostingProfileToCloseSettlement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfileToCloseSettlement;
        partial void OnPostingProfileToCloseSettlementChanging(string value);
        partial void OnPostingProfileToCloseSettlementChanged();
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
        /// There are no comments for Property IsTransactionIncludedInInterestCalculation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsTransactionIncludedInInterestCalculation")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTransactionIncludedInInterestCalculation
        {
            get
            {
                return this._IsTransactionIncludedInInterestCalculation;
            }
            set
            {
                this.OnIsTransactionIncludedInInterestCalculationChanging(value);
                this._IsTransactionIncludedInInterestCalculation = value;
                this.OnIsTransactionIncludedInInterestCalculationChanged();
                this.OnPropertyChanged("IsTransactionIncludedInInterestCalculation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTransactionIncludedInInterestCalculation;
        partial void OnIsTransactionIncludedInInterestCalculationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTransactionIncludedInInterestCalculationChanged();
        /// <summary>
        /// There are no comments for Property IsTransactionIncludedInAutoSettlement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsTransactionIncludedInAutoSettlement")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTransactionIncludedInAutoSettlement
        {
            get
            {
                return this._IsTransactionIncludedInAutoSettlement;
            }
            set
            {
                this.OnIsTransactionIncludedInAutoSettlementChanging(value);
                this._IsTransactionIncludedInAutoSettlement = value;
                this.OnIsTransactionIncludedInAutoSettlementChanged();
                this.OnPropertyChanged("IsTransactionIncludedInAutoSettlement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTransactionIncludedInAutoSettlement;
        partial void OnIsTransactionIncludedInAutoSettlementChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTransactionIncludedInAutoSettlementChanged();
        /// <summary>
        /// There are no comments for Property IsTransactionIncludedInCollectionLetterGeneration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsTransactionIncludedInCollectionLetterGeneration")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTransactionIncludedInCollectionLetterGeneration
        {
            get
            {
                return this._IsTransactionIncludedInCollectionLetterGeneration;
            }
            set
            {
                this.OnIsTransactionIncludedInCollectionLetterGenerationChanging(value);
                this._IsTransactionIncludedInCollectionLetterGeneration = value;
                this.OnIsTransactionIncludedInCollectionLetterGenerationChanged();
                this.OnPropertyChanged("IsTransactionIncludedInCollectionLetterGeneration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTransactionIncludedInCollectionLetterGeneration;
        partial void OnIsTransactionIncludedInCollectionLetterGenerationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTransactionIncludedInCollectionLetterGenerationChanged();
        /// <summary>
        /// There are no comments for Property AllowEmptyDimensionValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowEmptyDimensionValue")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimSettlementCtrlType_RU> AllowEmptyDimensionValue
        {
            get
            {
                return this._AllowEmptyDimensionValue;
            }
            set
            {
                this.OnAllowEmptyDimensionValueChanging(value);
                this._AllowEmptyDimensionValue = value;
                this.OnAllowEmptyDimensionValueChanged();
                this.OnPropertyChanged("AllowEmptyDimensionValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimSettlementCtrlType_RU> _AllowEmptyDimensionValue;
        partial void OnAllowEmptyDimensionValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimSettlementCtrlType_RU> value);
        partial void OnAllowEmptyDimensionValueChanged();
        /// <summary>
        /// There are no comments for Property CustCustomerPostingProfileHead in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustCustomerPostingProfileHead")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine> CustCustomerPostingProfileHead
        {
            get
            {
                return this._CustCustomerPostingProfileHead;
            }
            set
            {
                this.OnCustCustomerPostingProfileHeadChanging(value);
                this._CustCustomerPostingProfileHead = value;
                this.OnCustCustomerPostingProfileHeadChanged();
                this.OnPropertyChanged("CustCustomerPostingProfileHead");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine> _CustCustomerPostingProfileHead = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustCustomerPostingProfileHeadChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPostingProfileLine> value);
        partial void OnCustCustomerPostingProfileHeadChanged();
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
