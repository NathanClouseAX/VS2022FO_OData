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
    /// There are no comments for AccountStructureConstraintSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccountStructureConstraintSingle")]
    public partial class AccountStructureConstraintSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccountStructureConstraint>
    {
        /// <summary>
        /// Initialize a new AccountStructureConstraintSingle object.
        /// </summary>
        public AccountStructureConstraintSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccountStructureConstraintSingle object.
        /// </summary>
        public AccountStructureConstraintSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccountStructureConstraintSingle object.
        /// </summary>
        public AccountStructureConstraintSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccountStructureConstraint> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccountStructureSingle LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity == null))
                {
                    this._LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity = new global::Microsoft.Dynamics.DataEntities.AccountStructureSingle(this.Context, GetPath("LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity"));
                }
                return this._LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccountStructureSingle _LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity;
    }
    /// <summary>
    /// There are no comments for AccountStructureConstraint in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AccountStructure
    /// Status
    /// Position
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccountStructure", "Status", "Position")]
    [global::Microsoft.OData.Client.EntitySet("AccountStructureConstraints")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AccountStructureConstraint")]
    public partial class AccountStructureConstraint : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccountStructureConstraint object.
        /// </summary>
        /// <param name="accountStructure">Initial value of AccountStructure.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="activeTo">Initial value of ActiveTo.</param>
        /// <param name="activeFrom">Initial value of ActiveFrom.</param>
        /// <param name="ledgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity">Initial value of LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccountStructureConstraint CreateAccountStructureConstraint(string accountStructure, int position, global::System.DateTimeOffset activeTo, global::System.DateTimeOffset activeFrom, global::Microsoft.Dynamics.DataEntities.AccountStructure ledgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity)
        {
            AccountStructureConstraint accountStructureConstraint = new AccountStructureConstraint();
            accountStructureConstraint.AccountStructure = accountStructure;
            accountStructureConstraint.Position = position;
            accountStructureConstraint.ActiveTo = activeTo;
            accountStructureConstraint.ActiveFrom = activeFrom;
            if ((ledgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity == null))
            {
                throw new global::System.ArgumentNullException("ledgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity");
            }
            accountStructureConstraint.LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity = ledgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity;
            return accountStructureConstraint;
        }
        /// <summary>
        /// There are no comments for Property AccountStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountStructure")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountStructure is required.")]
        public virtual string AccountStructure
        {
            get
            {
                return this._AccountStructure;
            }
            set
            {
                this.OnAccountStructureChanging(value);
                this._AccountStructure = value;
                this.OnAccountStructureChanged();
                this.OnPropertyChanged("AccountStructure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountStructure;
        partial void OnAccountStructureChanging(string value);
        partial void OnAccountStructureChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionHierarchyConstraintStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionHierarchyConstraintStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DimensionHierarchyConstraintStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Position")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Position is required.")]
        public virtual int Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Position;
        partial void OnPositionChanging(int value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property ActiveTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveTo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActiveTo is required.")]
        public virtual global::System.DateTimeOffset ActiveTo
        {
            get
            {
                return this._ActiveTo;
            }
            set
            {
                this.OnActiveToChanging(value);
                this._ActiveTo = value;
                this.OnActiveToChanged();
                this.OnPropertyChanged("ActiveTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActiveTo;
        partial void OnActiveToChanging(global::System.DateTimeOffset value);
        partial void OnActiveToChanged();
        /// <summary>
        /// There are no comments for Property ActiveFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ActiveFrom is required.")]
        public virtual global::System.DateTimeOffset ActiveFrom
        {
            get
            {
                return this._ActiveFrom;
            }
            set
            {
                this.OnActiveFromChanging(value);
                this._ActiveFrom = value;
                this.OnActiveFromChanged();
                this.OnPropertyChanged("ActiveFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ActiveFrom;
        partial void OnActiveFromChanging(global::System.DateTimeOffset value);
        partial void OnActiveFromChanged();
        /// <summary>
        /// There are no comments for Property SegmentCriteria11 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria11")]
        public virtual string SegmentCriteria11
        {
            get
            {
                return this._SegmentCriteria11;
            }
            set
            {
                this.OnSegmentCriteria11Changing(value);
                this._SegmentCriteria11 = value;
                this.OnSegmentCriteria11Changed();
                this.OnPropertyChanged("SegmentCriteria11");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria11;
        partial void OnSegmentCriteria11Changing(string value);
        partial void OnSegmentCriteria11Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria10 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria10")]
        public virtual string SegmentCriteria10
        {
            get
            {
                return this._SegmentCriteria10;
            }
            set
            {
                this.OnSegmentCriteria10Changing(value);
                this._SegmentCriteria10 = value;
                this.OnSegmentCriteria10Changed();
                this.OnPropertyChanged("SegmentCriteria10");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria10;
        partial void OnSegmentCriteria10Changing(string value);
        partial void OnSegmentCriteria10Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria05 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria05")]
        public virtual string SegmentCriteria05
        {
            get
            {
                return this._SegmentCriteria05;
            }
            set
            {
                this.OnSegmentCriteria05Changing(value);
                this._SegmentCriteria05 = value;
                this.OnSegmentCriteria05Changed();
                this.OnPropertyChanged("SegmentCriteria05");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria05;
        partial void OnSegmentCriteria05Changing(string value);
        partial void OnSegmentCriteria05Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria04 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria04")]
        public virtual string SegmentCriteria04
        {
            get
            {
                return this._SegmentCriteria04;
            }
            set
            {
                this.OnSegmentCriteria04Changing(value);
                this._SegmentCriteria04 = value;
                this.OnSegmentCriteria04Changed();
                this.OnPropertyChanged("SegmentCriteria04");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria04;
        partial void OnSegmentCriteria04Changing(string value);
        partial void OnSegmentCriteria04Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria07 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria07")]
        public virtual string SegmentCriteria07
        {
            get
            {
                return this._SegmentCriteria07;
            }
            set
            {
                this.OnSegmentCriteria07Changing(value);
                this._SegmentCriteria07 = value;
                this.OnSegmentCriteria07Changed();
                this.OnPropertyChanged("SegmentCriteria07");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria07;
        partial void OnSegmentCriteria07Changing(string value);
        partial void OnSegmentCriteria07Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria06 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria06")]
        public virtual string SegmentCriteria06
        {
            get
            {
                return this._SegmentCriteria06;
            }
            set
            {
                this.OnSegmentCriteria06Changing(value);
                this._SegmentCriteria06 = value;
                this.OnSegmentCriteria06Changed();
                this.OnPropertyChanged("SegmentCriteria06");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria06;
        partial void OnSegmentCriteria06Changing(string value);
        partial void OnSegmentCriteria06Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria01 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria01")]
        public virtual string SegmentCriteria01
        {
            get
            {
                return this._SegmentCriteria01;
            }
            set
            {
                this.OnSegmentCriteria01Changing(value);
                this._SegmentCriteria01 = value;
                this.OnSegmentCriteria01Changed();
                this.OnPropertyChanged("SegmentCriteria01");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria01;
        partial void OnSegmentCriteria01Changing(string value);
        partial void OnSegmentCriteria01Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria03 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria03")]
        public virtual string SegmentCriteria03
        {
            get
            {
                return this._SegmentCriteria03;
            }
            set
            {
                this.OnSegmentCriteria03Changing(value);
                this._SegmentCriteria03 = value;
                this.OnSegmentCriteria03Changed();
                this.OnPropertyChanged("SegmentCriteria03");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria03;
        partial void OnSegmentCriteria03Changing(string value);
        partial void OnSegmentCriteria03Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria02 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria02")]
        public virtual string SegmentCriteria02
        {
            get
            {
                return this._SegmentCriteria02;
            }
            set
            {
                this.OnSegmentCriteria02Changing(value);
                this._SegmentCriteria02 = value;
                this.OnSegmentCriteria02Changed();
                this.OnPropertyChanged("SegmentCriteria02");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria02;
        partial void OnSegmentCriteria02Changing(string value);
        partial void OnSegmentCriteria02Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria09 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria09")]
        public virtual string SegmentCriteria09
        {
            get
            {
                return this._SegmentCriteria09;
            }
            set
            {
                this.OnSegmentCriteria09Changing(value);
                this._SegmentCriteria09 = value;
                this.OnSegmentCriteria09Changed();
                this.OnPropertyChanged("SegmentCriteria09");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria09;
        partial void OnSegmentCriteria09Changing(string value);
        partial void OnSegmentCriteria09Changed();
        /// <summary>
        /// There are no comments for Property SegmentCriteria08 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SegmentCriteria08")]
        public virtual string SegmentCriteria08
        {
            get
            {
                return this._SegmentCriteria08;
            }
            set
            {
                this.OnSegmentCriteria08Changing(value);
                this._SegmentCriteria08 = value;
                this.OnSegmentCriteria08Changed();
                this.OnPropertyChanged("SegmentCriteria08");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SegmentCriteria08;
        partial void OnSegmentCriteria08Changing(string value);
        partial void OnSegmentCriteria08Changed();
        /// <summary>
        /// There are no comments for Property LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccountStructure LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity
        {
            get
            {
                return this._LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity;
            }
            set
            {
                this.OnLedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntityChanging(value);
                this._LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity = value;
                this.OnLedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntityChanged();
                this.OnPropertyChanged("LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccountStructure _LedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntity;
        partial void OnLedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntityChanging(global::Microsoft.Dynamics.DataEntities.AccountStructure value);
        partial void OnLedgerAccountStructureConstraintEntity_RelatedRole_LedgerAccountStructureEntityChanged();
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
