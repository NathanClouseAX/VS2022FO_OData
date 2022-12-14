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
    /// There are no comments for ExpenseSharedSubCategorySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseSharedSubCategorySingle")]
    public partial class ExpenseSharedSubCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseSharedSubCategory>
    {
        /// <summary>
        /// Initialize a new ExpenseSharedSubCategorySingle object.
        /// </summary>
        public ExpenseSharedSubCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExpenseSharedSubCategorySingle object.
        /// </summary>
        public ExpenseSharedSubCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExpenseSharedSubCategorySingle object.
        /// </summary>
        public ExpenseSharedSubCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseSharedSubCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BelongsTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BelongsTo")]
        public virtual global::Microsoft.Dynamics.DataEntities.SharedCategorySingle BelongsTo
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BelongsTo == null))
                {
                    this._BelongsTo = new global::Microsoft.Dynamics.DataEntities.SharedCategorySingle(this.Context, GetPath("BelongsTo"));
                }
                return this._BelongsTo;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SharedCategorySingle _BelongsTo;
        /// <summary>
        /// There are no comments for ExpenseSubCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseSubCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory> ExpenseSubCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ExpenseSubCategory == null))
                {
                    this._ExpenseSubCategory = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory>(GetPath("ExpenseSubCategory"));
                }
                return this._ExpenseSubCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory> _ExpenseSubCategory;
    }
    /// <summary>
    /// There are no comments for ExpenseSharedSubCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// SharedCategoryId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name", "SharedCategoryId")]
    [global::Microsoft.OData.Client.EntitySet("ExpenseSharedSubCategories")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseSharedSubCategory")]
    public partial class ExpenseSharedSubCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExpenseSharedSubCategory object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="sharedCategoryId">Initial value of SharedCategoryId.</param>
        /// <param name="chargeType">Initial value of ChargeType.</param>
        /// <param name="belongsTo">Initial value of BelongsTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExpenseSharedSubCategory CreateExpenseSharedSubCategory(string name, string sharedCategoryId, int chargeType, global::Microsoft.Dynamics.DataEntities.SharedCategory belongsTo)
        {
            ExpenseSharedSubCategory expenseSharedSubCategory = new ExpenseSharedSubCategory();
            expenseSharedSubCategory.Name = name;
            expenseSharedSubCategory.SharedCategoryId = sharedCategoryId;
            expenseSharedSubCategory.ChargeType = chargeType;
            if ((belongsTo == null))
            {
                throw new global::System.ArgumentNullException("belongsTo");
            }
            expenseSharedSubCategory.BelongsTo = belongsTo;
            return expenseSharedSubCategory;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property SharedCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SharedCategoryId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SharedCategoryId is required.")]
        public virtual string SharedCategoryId
        {
            get
            {
                return this._SharedCategoryId;
            }
            set
            {
                this.OnSharedCategoryIdChanging(value);
                this._SharedCategoryId = value;
                this.OnSharedCategoryIdChanged();
                this.OnPropertyChanged("SharedCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SharedCategoryId;
        partial void OnSharedCategoryIdChanging(string value);
        partial void OnSharedCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property SystemCreated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SystemCreated")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SystemCreated
        {
            get
            {
                return this._SystemCreated;
            }
            set
            {
                this.OnSystemCreatedChanging(value);
                this._SystemCreated = value;
                this.OnSystemCreatedChanged();
                this.OnPropertyChanged("SystemCreated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SystemCreated;
        partial void OnSystemCreatedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSystemCreatedChanged();
        /// <summary>
        /// There are no comments for Property ChargeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ChargeType is required.")]
        public virtual int ChargeType
        {
            get
            {
                return this._ChargeType;
            }
            set
            {
                this.OnChargeTypeChanging(value);
                this._ChargeType = value;
                this.OnChargeTypeChanged();
                this.OnPropertyChanged("ChargeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ChargeType;
        partial void OnChargeTypeChanging(int value);
        partial void OnChargeTypeChanged();
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
        /// There are no comments for Property ExcludeFromRecovery in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExcludeFromRecovery")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ExcludeFromRecovery
        {
            get
            {
                return this._ExcludeFromRecovery;
            }
            set
            {
                this.OnExcludeFromRecoveryChanging(value);
                this._ExcludeFromRecovery = value;
                this.OnExcludeFromRecoveryChanged();
                this.OnPropertyChanged("ExcludeFromRecovery");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ExcludeFromRecovery;
        partial void OnExcludeFromRecoveryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnExcludeFromRecoveryChanged();
        /// <summary>
        /// There are no comments for Property BelongsTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BelongsTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BelongsTo is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.SharedCategory BelongsTo
        {
            get
            {
                return this._BelongsTo;
            }
            set
            {
                this.OnBelongsToChanging(value);
                this._BelongsTo = value;
                this.OnBelongsToChanged();
                this.OnPropertyChanged("BelongsTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SharedCategory _BelongsTo;
        partial void OnBelongsToChanging(global::Microsoft.Dynamics.DataEntities.SharedCategory value);
        partial void OnBelongsToChanged();
        /// <summary>
        /// There are no comments for Property ExpenseSubCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseSubCategory")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory> ExpenseSubCategory
        {
            get
            {
                return this._ExpenseSubCategory;
            }
            set
            {
                this.OnExpenseSubCategoryChanging(value);
                this._ExpenseSubCategory = value;
                this.OnExpenseSubCategoryChanged();
                this.OnPropertyChanged("ExpenseSubCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory> _ExpenseSubCategory = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnExpenseSubCategoryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ExpenseSubCategory> value);
        partial void OnExpenseSubCategoryChanged();
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
