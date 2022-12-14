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
    /// There are no comments for CompensationPerformanceRatingSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationPerformanceRatingSingle")]
    public partial class CompensationPerformanceRatingSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPerformanceRating>
    {
        /// <summary>
        /// Initialize a new CompensationPerformanceRatingSingle object.
        /// </summary>
        public CompensationPerformanceRatingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationPerformanceRatingSingle object.
        /// </summary>
        public CompensationPerformanceRatingSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationPerformanceRatingSingle object.
        /// </summary>
        public CompensationPerformanceRatingSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPerformanceRating> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationPayPerformanceAllocationLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationPayPerformanceAllocationLine")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> CompensationPayPerformanceAllocationLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationPayPerformanceAllocationLine == null))
                {
                    this._CompensationPayPerformanceAllocationLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine>(GetPath("CompensationPayPerformanceAllocationLine"));
                }
                return this._CompensationPayPerformanceAllocationLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> _CompensationPayPerformanceAllocationLine;
    }
    /// <summary>
    /// There are no comments for CompensationPerformanceRating in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// Rating
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Rating")]
    [global::Microsoft.OData.Client.EntitySet("CompensationPerformanceRatings")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationPerformanceRating")]
    public partial class CompensationPerformanceRating : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationPerformanceRating object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="rating">Initial value of Rating.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        /// <param name="effective">Initial value of Effective.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationPerformanceRating CreateCompensationPerformanceRating(string dataAreaId, string rating, global::System.DateTimeOffset expiration, global::System.DateTimeOffset effective)
        {
            CompensationPerformanceRating compensationPerformanceRating = new CompensationPerformanceRating();
            compensationPerformanceRating.DataAreaId = dataAreaId;
            compensationPerformanceRating.Rating = rating;
            compensationPerformanceRating.Expiration = expiration;
            compensationPerformanceRating.Effective = effective;
            return compensationPerformanceRating;
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
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Rating")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Rating is required.")]
        public virtual string Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
                this.OnPropertyChanged("Rating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Rating;
        partial void OnRatingChanging(string value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Expiration")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Expiration is required.")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
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
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Effective")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Effective is required.")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property CompensationPayPerformanceAllocationLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompensationPayPerformanceAllocationLine")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> CompensationPayPerformanceAllocationLine
        {
            get
            {
                return this._CompensationPayPerformanceAllocationLine;
            }
            set
            {
                this.OnCompensationPayPerformanceAllocationLineChanging(value);
                this._CompensationPayPerformanceAllocationLine = value;
                this.OnCompensationPayPerformanceAllocationLineChanged();
                this.OnPropertyChanged("CompensationPayPerformanceAllocationLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> _CompensationPayPerformanceAllocationLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationPayPerformanceAllocationLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> value);
        partial void OnCompensationPayPerformanceAllocationLineChanged();
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
