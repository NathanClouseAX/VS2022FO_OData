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
    /// There are no comments for LoanTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LoanTypeSingle")]
    public partial class LoanTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LoanType>
    {
        /// <summary>
        /// Initialize a new LoanTypeSingle object.
        /// </summary>
        public LoanTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LoanTypeSingle object.
        /// </summary>
        public LoanTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LoanTypeSingle object.
        /// </summary>
        public LoanTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LoanType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LoanItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LoanItem")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LoanItem> LoanItem
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LoanItem == null))
                {
                    this._LoanItem = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LoanItem>(GetPath("LoanItem"));
                }
                return this._LoanItem;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LoanItem> _LoanItem;
    }
    /// <summary>
    /// There are no comments for LoanType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LoanTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LoanTypeId")]
    [global::Microsoft.OData.Client.EntitySet("LoanTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LoanType")]
    public partial class LoanType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LoanType object.
        /// </summary>
        /// <param name="loanTypeId">Initial value of LoanTypeId.</param>
        /// <param name="gracePeriodDays">Initial value of GracePeriodDays.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LoanType CreateLoanType(string loanTypeId, int gracePeriodDays)
        {
            LoanType loanType = new LoanType();
            loanType.LoanTypeId = loanTypeId;
            loanType.GracePeriodDays = gracePeriodDays;
            return loanType;
        }
        /// <summary>
        /// There are no comments for Property LoanTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoanTypeId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LoanTypeId is required.")]
        public virtual string LoanTypeId
        {
            get
            {
                return this._LoanTypeId;
            }
            set
            {
                this.OnLoanTypeIdChanging(value);
                this._LoanTypeId = value;
                this.OnLoanTypeIdChanged();
                this.OnPropertyChanged("LoanTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LoanTypeId;
        partial void OnLoanTypeIdChanging(string value);
        partial void OnLoanTypeIdChanged();
        /// <summary>
        /// There are no comments for Property GracePeriodDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GracePeriodDays")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GracePeriodDays is required.")]
        public virtual int GracePeriodDays
        {
            get
            {
                return this._GracePeriodDays;
            }
            set
            {
                this.OnGracePeriodDaysChanging(value);
                this._GracePeriodDays = value;
                this.OnGracePeriodDaysChanged();
                this.OnPropertyChanged("GracePeriodDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _GracePeriodDays;
        partial void OnGracePeriodDaysChanging(int value);
        partial void OnGracePeriodDaysChanged();
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
        /// There are no comments for Property LoanItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LoanItem")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanItem> LoanItem
        {
            get
            {
                return this._LoanItem;
            }
            set
            {
                this.OnLoanItemChanging(value);
                this._LoanItem = value;
                this.OnLoanItemChanged();
                this.OnPropertyChanged("LoanItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanItem> _LoanItem = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanItem>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLoanItemChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LoanItem> value);
        partial void OnLoanItemChanged();
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
