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
    /// There are no comments for PeriodicDiscountAllocationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodicDiscountAllocationSingle")]
    public partial class PeriodicDiscountAllocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodicDiscountAllocation>
    {
        /// <summary>
        /// Initialize a new PeriodicDiscountAllocationSingle object.
        /// </summary>
        public PeriodicDiscountAllocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PeriodicDiscountAllocationSingle object.
        /// </summary>
        public PeriodicDiscountAllocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PeriodicDiscountAllocationSingle object.
        /// </summary>
        public PeriodicDiscountAllocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PeriodicDiscountAllocation> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PeriodicDiscountAllocation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// OfferId
    /// LineNum
    /// PostingProfile
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OfferId", "LineNum", "PostingProfile")]
    [global::Microsoft.OData.Client.EntitySet("PeriodicDiscountAllocations")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodicDiscountAllocation")]
    public partial class PeriodicDiscountAllocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PeriodicDiscountAllocation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="offerId">Initial value of OfferId.</param>
        /// <param name="lineNum">Initial value of LineNum.</param>
        /// <param name="postingProfile">Initial value of PostingProfile.</param>
        /// <param name="discountPercentOrValue">Initial value of DiscountPercentOrValue.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PeriodicDiscountAllocation CreatePeriodicDiscountAllocation(string dataAreaId, string offerId, decimal lineNum, string postingProfile, decimal discountPercentOrValue)
        {
            PeriodicDiscountAllocation periodicDiscountAllocation = new PeriodicDiscountAllocation();
            periodicDiscountAllocation.DataAreaId = dataAreaId;
            periodicDiscountAllocation.OfferId = offerId;
            periodicDiscountAllocation.LineNum = lineNum;
            periodicDiscountAllocation.PostingProfile = postingProfile;
            periodicDiscountAllocation.DiscountPercentOrValue = discountPercentOrValue;
            return periodicDiscountAllocation;
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
        /// There are no comments for Property OfferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OfferId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OfferId is required.")]
        public virtual string OfferId
        {
            get
            {
                return this._OfferId;
            }
            set
            {
                this.OnOfferIdChanging(value);
                this._OfferId = value;
                this.OnOfferIdChanged();
                this.OnPropertyChanged("OfferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfferId;
        partial void OnOfferIdChanging(string value);
        partial void OnOfferIdChanged();
        /// <summary>
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineNum is required.")]
        public virtual decimal LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNum;
        partial void OnLineNumChanging(decimal value);
        partial void OnLineNumChanged();
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
        /// There are no comments for Property DiscountPercentOrValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPercentOrValue")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DiscountPercentOrValue is required.")]
        public virtual decimal DiscountPercentOrValue
        {
            get
            {
                return this._DiscountPercentOrValue;
            }
            set
            {
                this.OnDiscountPercentOrValueChanging(value);
                this._DiscountPercentOrValue = value;
                this.OnDiscountPercentOrValueChanged();
                this.OnPropertyChanged("DiscountPercentOrValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DiscountPercentOrValue;
        partial void OnDiscountPercentOrValueChanging(decimal value);
        partial void OnDiscountPercentOrValueChanged();
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
