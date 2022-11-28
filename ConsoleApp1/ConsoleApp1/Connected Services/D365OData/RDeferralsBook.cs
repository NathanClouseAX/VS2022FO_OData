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
    /// There are no comments for RDeferralsBookSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RDeferralsBookSingle")]
    public partial class RDeferralsBookSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RDeferralsBook>
    {
        /// <summary>
        /// Initialize a new RDeferralsBookSingle object.
        /// </summary>
        public RDeferralsBookSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RDeferralsBookSingle object.
        /// </summary>
        public RDeferralsBookSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RDeferralsBookSingle object.
        /// </summary>
        public RDeferralsBookSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RDeferralsBook> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
    /// <summary>
    /// There are no comments for RDeferralsBook in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DataAreaId
    /// DeferralsId
    /// ModelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DeferralsId", "ModelNumber")]
    [global::Microsoft.OData.Client.EntitySet("RDeferralsBooks")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RDeferralsBook")]
    public partial class RDeferralsBook : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RDeferralsBook object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="deferralsId">Initial value of DeferralsId.</param>
        /// <param name="modelNumber">Initial value of ModelNumber.</param>
        /// <param name="writingOffTime">Initial value of WritingOffTime.</param>
        /// <param name="endDateOfWritingOff">Initial value of EndDateOfWritingOff.</param>
        /// <param name="beginningDateOfWritingOff">Initial value of BeginningDateOfWritingOff.</param>
        /// <param name="deferralsSum">Initial value of DeferralsSum.</param>
        /// <param name="disposalDate">Initial value of DisposalDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RDeferralsBook CreateRDeferralsBook(string dataAreaId, 
                    string deferralsId, 
                    string modelNumber, 
                    int writingOffTime, 
                    global::System.DateTimeOffset endDateOfWritingOff, 
                    global::System.DateTimeOffset beginningDateOfWritingOff, 
                    decimal deferralsSum, 
                    global::System.DateTimeOffset disposalDate)
        {
            RDeferralsBook rDeferralsBook = new RDeferralsBook();
            rDeferralsBook.DataAreaId = dataAreaId;
            rDeferralsBook.DeferralsId = deferralsId;
            rDeferralsBook.ModelNumber = modelNumber;
            rDeferralsBook.WritingOffTime = writingOffTime;
            rDeferralsBook.EndDateOfWritingOff = endDateOfWritingOff;
            rDeferralsBook.BeginningDateOfWritingOff = beginningDateOfWritingOff;
            rDeferralsBook.DeferralsSum = deferralsSum;
            rDeferralsBook.DisposalDate = disposalDate;
            return rDeferralsBook;
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
        /// There are no comments for Property DeferralsId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralsId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeferralsId is required.")]
        public virtual string DeferralsId
        {
            get
            {
                return this._DeferralsId;
            }
            set
            {
                this.OnDeferralsIdChanging(value);
                this._DeferralsId = value;
                this.OnDeferralsIdChanged();
                this.OnPropertyChanged("DeferralsId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeferralsId;
        partial void OnDeferralsIdChanging(string value);
        partial void OnDeferralsIdChanged();
        /// <summary>
        /// There are no comments for Property ModelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ModelNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ModelNumber is required.")]
        public virtual string ModelNumber
        {
            get
            {
                return this._ModelNumber;
            }
            set
            {
                this.OnModelNumberChanging(value);
                this._ModelNumber = value;
                this.OnModelNumberChanged();
                this.OnPropertyChanged("ModelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelNumber;
        partial void OnModelNumberChanging(string value);
        partial void OnModelNumberChanged();
        /// <summary>
        /// There are no comments for Property WritingOffTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WritingOffTime")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "WritingOffTime is required.")]
        public virtual int WritingOffTime
        {
            get
            {
                return this._WritingOffTime;
            }
            set
            {
                this.OnWritingOffTimeChanging(value);
                this._WritingOffTime = value;
                this.OnWritingOffTimeChanged();
                this.OnPropertyChanged("WritingOffTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _WritingOffTime;
        partial void OnWritingOffTimeChanging(int value);
        partial void OnWritingOffTimeChanged();
        /// <summary>
        /// There are no comments for Property EndDateOfWritingOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDateOfWritingOff")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EndDateOfWritingOff is required.")]
        public virtual global::System.DateTimeOffset EndDateOfWritingOff
        {
            get
            {
                return this._EndDateOfWritingOff;
            }
            set
            {
                this.OnEndDateOfWritingOffChanging(value);
                this._EndDateOfWritingOff = value;
                this.OnEndDateOfWritingOffChanged();
                this.OnPropertyChanged("EndDateOfWritingOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EndDateOfWritingOff;
        partial void OnEndDateOfWritingOffChanging(global::System.DateTimeOffset value);
        partial void OnEndDateOfWritingOffChanged();
        /// <summary>
        /// There are no comments for Property WritingOffMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WritingOffMethod")]
        public virtual string WritingOffMethod
        {
            get
            {
                return this._WritingOffMethod;
            }
            set
            {
                this.OnWritingOffMethodChanging(value);
                this._WritingOffMethod = value;
                this.OnWritingOffMethodChanged();
                this.OnPropertyChanged("WritingOffMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WritingOffMethod;
        partial void OnWritingOffMethodChanging(string value);
        partial void OnWritingOffMethodChanged();
        /// <summary>
        /// There are no comments for Property MainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainAccountDisplayValue")]
        public virtual string MainAccountDisplayValue
        {
            get
            {
                return this._MainAccountDisplayValue;
            }
            set
            {
                this.OnMainAccountDisplayValueChanging(value);
                this._MainAccountDisplayValue = value;
                this.OnMainAccountDisplayValueChanged();
                this.OnPropertyChanged("MainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountDisplayValue;
        partial void OnMainAccountDisplayValueChanging(string value);
        partial void OnMainAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionDisplayValue")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property Lock in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Lock")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Lock
        {
            get
            {
                return this._Lock;
            }
            set
            {
                this.OnLockChanging(value);
                this._Lock = value;
                this.OnLockChanged();
                this.OnPropertyChanged("Lock");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Lock;
        partial void OnLockChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnLockChanged();
        /// <summary>
        /// There are no comments for Property DeferralsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralsGroup")]
        public virtual string DeferralsGroup
        {
            get
            {
                return this._DeferralsGroup;
            }
            set
            {
                this.OnDeferralsGroupChanging(value);
                this._DeferralsGroup = value;
                this.OnDeferralsGroupChanged();
                this.OnPropertyChanged("DeferralsGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeferralsGroup;
        partial void OnDeferralsGroupChanging(string value);
        partial void OnDeferralsGroupChanged();
        /// <summary>
        /// There are no comments for Property PostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingProfile")]
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
        /// There are no comments for Property BeginningDateOfWritingOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BeginningDateOfWritingOff")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BeginningDateOfWritingOff is required.")]
        public virtual global::System.DateTimeOffset BeginningDateOfWritingOff
        {
            get
            {
                return this._BeginningDateOfWritingOff;
            }
            set
            {
                this.OnBeginningDateOfWritingOffChanging(value);
                this._BeginningDateOfWritingOff = value;
                this.OnBeginningDateOfWritingOffChanged();
                this.OnPropertyChanged("BeginningDateOfWritingOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _BeginningDateOfWritingOff;
        partial void OnBeginningDateOfWritingOffChanging(global::System.DateTimeOffset value);
        partial void OnBeginningDateOfWritingOffChanged();
        /// <summary>
        /// There are no comments for Property DeferralsSum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeferralsSum")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DeferralsSum is required.")]
        public virtual decimal DeferralsSum
        {
            get
            {
                return this._DeferralsSum;
            }
            set
            {
                this.OnDeferralsSumChanging(value);
                this._DeferralsSum = value;
                this.OnDeferralsSumChanged();
                this.OnPropertyChanged("DeferralsSum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DeferralsSum;
        partial void OnDeferralsSumChanging(decimal value);
        partial void OnDeferralsSumChanged();
        /// <summary>
        /// There are no comments for Property DisposalDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisposalDate")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DisposalDate is required.")]
        public virtual global::System.DateTimeOffset DisposalDate
        {
            get
            {
                return this._DisposalDate;
            }
            set
            {
                this.OnDisposalDateChanging(value);
                this._DisposalDate = value;
                this.OnDisposalDateChanged();
                this.OnPropertyChanged("DisposalDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DisposalDate;
        partial void OnDisposalDateChanging(global::System.DateTimeOffset value);
        partial void OnDisposalDateChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCombination")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSet")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
